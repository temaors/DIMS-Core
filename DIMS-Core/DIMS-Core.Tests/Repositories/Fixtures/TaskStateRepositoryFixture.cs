using System;
using DIMS_Core.DataAccessLayer.Models;
using DIMS_Core.DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DIMS_Core.Tests.Repositories.Fixtures;

public class TaskStateRepositoryFixture : AbstractRepositoryFixture<TaskState>
{
    public TaskStateRepositoryFixture() : base(typeof(TaskStateRepository))
    {
    }

    protected override void InitDatabase()
    {
        var entry = Context.TaskStates.Add(new TaskState()
                               {
                                    StateName = "Failed"
                               });
        Context.SaveChanges();
        entry.State = EntityState.Detached;
    }
}