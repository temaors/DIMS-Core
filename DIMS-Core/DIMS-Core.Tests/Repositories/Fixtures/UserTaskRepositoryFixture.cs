using System;
using DIMS_Core.DataAccessLayer.Models;
using DIMS_Core.DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DIMS_Core.Tests.Repositories.Fixtures;

public class UserTaskRepositoryFixture : AbstractRepositoryFixture<UserTask>
{
    public UserTaskRepositoryFixture() : base(typeof(UserTaskRepository))
    {
    }

    protected override void InitDatabase()
    {
        var entry = Context.Add(new UserTask()
                                {
                                    TaskId = 1,
                                    UserTaskId = 1,
                                    StateId = 1,
                                });
        
        Context.SaveChanges();
        entry.State = EntityState.Detached;
    }
}