using System;
using DIMS_Core.DataAccessLayer.Interfaces;
using DIMS_Core.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DIMS_Core.Tests.Repositories.Fixtures;

public abstract class AbstractRepositoryFixture<TEntity> : IDisposable
    where TEntity : class
{

    public DimsCoreContext Context { get; }
    public IRepository<TEntity> Repository { get; }
    
    public AbstractRepositoryFixture(Type repositoryType)
    {
        Context = CreateContext();
        Repository = (IRepository<TEntity>)Activator.CreateInstance(repositoryType, Context);   
        InitDatabase();
    }

    public void Dispose()
    {
        Context.Dispose();
    }

    protected abstract void InitDatabase();

    private static DimsCoreContext CreateContext()
    {
        var options = GetOptions();

        return new DimsCoreContext(options);
    }

    private static DbContextOptions<DimsCoreContext> GetOptions()
    {
        var builder = new DbContextOptionsBuilder<DimsCoreContext>().UseInMemoryDatabase(GetInMemoryDbName());

        return builder.Options;
    }

    private static string GetInMemoryDbName()
    {
        return $"InMemory_{Guid.NewGuid()}";
    }
}
