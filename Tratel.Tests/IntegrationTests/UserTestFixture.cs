using NUnit.Framework;
using System;
using Tratel.Common.Services.Repositories;
using Tratel.Contracts.Users;

namespace Tratel.Tests.IntegrationTests;

[TestFixture]
public class UserTestFixture : IntegrationTest
{
    public UserTestFixture()
    {
        Sut = new UserRepository();
    }
    public UserRepository Sut { get; set; }
    [Test]
    public void CanAddNewUser()
    {
        var data = new NewUserDto
        {
            FullName = "Can Perk",
            Mail = "can@mail.com",
            PassportNumber = "UA378483",
            Password = "1234",
            NationalityId = Guid.Parse("3D97A7ED-6058-4772-B862-6C440F074A9B"),
            UserName = "cam.perk"
        };
        var result = Sut.CreateUser(data);
        Assert.That(result, Is.True);
    }
    
    [Test]
    public void CanNot_AddNewUser_WithExistingMail_Address()
    {
        var data = new NewUserDto
        {
            FullName = "New User",
            Mail = "canperk@mail.com",
            PassportNumber = "UA378483",
            Password = "1234",
            NationalityId = Guid.Parse("3D97A7ED-6058-4772-B862-6C440F074A9B"),
            UserName = "new.user"
        };
        var result = Sut.CreateUser(data);
        Assert.That(result, Is.False);
    }
}
