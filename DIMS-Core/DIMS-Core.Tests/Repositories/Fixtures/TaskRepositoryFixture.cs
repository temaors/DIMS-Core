using System;
using DIMS_Core.DataAccessLayer.Models;
using DIMS_Core.DataAccessLayer.Repositories;

namespace DIMS_Core.Tests.Repositories.Fixtures;

public class TaskRepositoryFixture : AbstractRepositoryFixture<Task>
{
    
    protected override void InitDatabase()
    {
        
    }

    public TaskRepositoryFixture() : base(typeof(TaskRepository))
    {
    }
}