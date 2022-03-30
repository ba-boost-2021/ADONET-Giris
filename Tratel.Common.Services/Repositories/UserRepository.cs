using Microsoft.EntityFrameworkCore;
using Tratel.Contracts.Users;
using Tratel.Data.Managers;
using Tratel.Entities.Auth;
using Tratel.Entities.Customer;

namespace Tratel.Common.Services.Repositories;

public class UserRepository
{
    public NewUserDto GetNewUserDto(Guid id)
    {
        var context = ConnectionManager.GetDbContext();
        var user = context.Users.Where(k => k.Id == id).Include(i => i.Person).ThenInclude(s => s.Nationality).Select(a => new NewUserDto
        {
            FullName = a.Person.FullName,
            Mail = a.Mail,
            PassportNumber = a.Person.PassportNumber,
            UserName = a.UserName,
            Password = a.Password,
            NationalityId = a.Person.NationalityId
        }).ToList();

        return user[0];
    }

    public bool UpdateUser(UpdateUserDto data, Guid userId)
    {
        var context = ConnectionManager.GetDbContext();

        var user = context.Users.Where(i => i.Id == userId).SingleOrDefault();
        if (user == null)
        {
            return false;
        }
        var person = context.Persons.Where(i => i.Id == user.PersonId).SingleOrDefault();
        if (user == null)
        {
            return false;
        }
        user.UserName = data.UserName;
        user.Password = data.Password;
        user.Mail = data.Mail;
        user.ModifiedAt = data.ModifiedDate;

        person.PassportNumber = data.PassportNumber;
        person.NationalityId = data.NationalityId;
        person.FullName = data.FullName;
        person.ModifiedAt = data.ModifiedDate;

        var result = context.SaveChanges();

        return result == 2;
    }

    public List<UserListDto> GetUsers()
    {
        var context = ConnectionManager.GetDbContext();
        return context.Users
                      .Include(i => i.Person).ThenInclude(i => i.Nationality)
                      .Select(s => new UserListDto
                      {
                          Id = s.Id,
                          UserName = s.UserName,
                          Mail = s.Mail,
                          FullName = s.Person.FullName,
                          Country = s.Person.Nationality.Name
                      }).ToList();

        //SELECT u.Id, u.UserName, u.Mail, p.FullName, l.Name AS Country
        //FROM Users
        //INNER JOIN Persons p ON p.Id = u.PersonId
        //INNER JOIN LookUps l ON l.Id = p.NationalityId

        //var query = context.Users
        //              .Include(i => i.Person).ThenInclude(i => i.Nationality)
        //              .Select(s => new UserListDto
        //              {
        //                  Id = s.Id,
        //                  UserName = s.UserName,
        //                  Mail = s.Mail,
        //                  FullName = s.Person.FullName,
        //                  Country = s.Person.Nationality.Name
        //              }).ToQueryString();
    }

    public bool CreateUser(NewUserDto newUser)
    {
        var context = ConnectionManager.GetDbContext();
        var person = new Person
        {
            FullName = newUser.FullName,
            NationalityId = newUser.NationalityId,
            PassportNumber = newUser.PassportNumber
        };
        context.Persons.Add(person);
        context.Users.Add(new User
        {
            Mail = newUser.Mail,
            UserName = newUser.UserName,
            Password = newUser.Password,
            PersonId = person.Id
        });

        var result = context.SaveChanges();
        return result == 2; // bir Person, bir User
    }

    public bool DeleteUser(Guid id)
    {
        var context = ConnectionManager.GetDbContext();
        var user = context.Users.SingleOrDefault(i => i.Id == id);
        if (user == null)
        {
            return false;
        }
        var person = context.Persons.SingleOrDefault(i => i.Id == user.PersonId);
        if (person == null)
        {
            return false;
        }

        context.Users.Remove(user);
        context.Persons.Remove(person);
        var result = context.SaveChanges();
        return result == 2;
    }
}