using Microsoft.EntityFrameworkCore;
using Tratel.Contracts.Users;
using Tratel.Data.Managers;
using Tratel.Entities.Auth;
using Tratel.Entities.Customer;

namespace Tratel.Common.Services.Repositories;

public class UserRepository
{
    public  NewUserDto GetNewUserDto(Guid id )
    {
        var context = ConnectionManager.GetDbContext();
        var user = context.Users.Where(k => k.Id == id).Include(i => i.Person).ThenInclude(s => s.Nationality).Select(a => new NewUserDto
                      {
                          FullName = a.Person.FullName,
                          Mail = a.Mail,
                          PassportNumber = a.Person.PassportNumber,
                          UserName = a.UserName,
                          Password = a.Password,
                          NationalityId = a.Person.NationalityId }).ToList() ;

        return user[0];

       

    }
    public bool UpdateUser(UpdateUserDto data)
    {
        var context = ConnectionManager.GetDbContext();

        var user= new User { UserName = data.UserName, ModifiedAt = data.ModifiedDate , Mail = data.Mail, Password = data.Password };
        context.Users.Update(user);

        var person = new Person { ModifiedAt = data.ModifiedDate, FullName = data.FullName, NationalityId = data.NationalityId, PassportNumber= data.PassportNumber };
        context.Persons.Update(person);

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
}
