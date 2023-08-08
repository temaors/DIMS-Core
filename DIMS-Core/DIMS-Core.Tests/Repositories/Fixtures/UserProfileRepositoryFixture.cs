using System;
using DIMS_Core.DataAccessLayer.Models;
using DIMS_Core.DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DIMS_Core.Tests.Repositories.Fixtures;

public class UserProfileRepositoryFixture : AbstractRepositoryFixture<UserProfile>
{
    public UserProfileRepositoryFixture() : base(typeof(UserProfileRepository))
    {
    }

    protected override void InitDatabase()
    {
        var entry = Context.UserProfiles.Add(new UserProfile()
                                             {
                                                 FirstName = "Artyom",
                                                 LastName = "Orsik",
                                                 Education = "BSUIR",
                                                 MobilePhone = "+375444717000",
                                                 Address = "address",
                                                 BirthDate = new DateTime(),
                                                 StartDate = DateTime.Now,
                                                 Skype = "temaors",
                                                 Email = "temaors@mail.ru",
                                                 UniversityAverageScore = 9.5,
                                                 MathScore = 10,
                                                 Sex = 1,
                                             });
        Context.SaveChanges();
        entry.State = EntityState.Detached;
    }
}