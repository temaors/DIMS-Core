using System;
using DIMS_Core.DataAccessLayer.Models;
using DIMS_Core.DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DIMS_Core.Tests.Repositories.Fixtures;

public class TaskRepositoryFixture : AbstractRepositoryFixture<Task>
{
    public TaskRepositoryFixture() : base(typeof(TaskRepository))
    {
    }
    
    protected override void InitDatabase()
    {
        var entry = Context.Tasks.Add(
        new Task()
        {
            Name = "Test Task name",
            Description = "Test Task description",
            StartDate = new DateTime(2023,8,8),
            DeadlineDate = new DateTime(2023,8,15)
        });
        
        Context.SaveChanges();
        entry.State = EntityState.Detached;
    }
}