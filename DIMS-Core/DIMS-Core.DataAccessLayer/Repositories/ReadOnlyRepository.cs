using System;
using System.Linq;
using DIMS_Core.DataAccessLayer.Interfaces;
using DIMS_Core.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DIMS_Core.DataAccessLayer.Repositories;

public abstract class ReadOnlyRepository<TEntity> : IReadOnlyRepository<TEntity>
    where TEntity : class
{
    protected readonly DimsCoreContext _context;
    
    public ReadOnlyRepository(DimsCoreContext context)
    {
        _context = context;
    }
    
    public IQueryable<TEntity> GetAll()
    {
        return _context.Set<TEntity>()
                       .AsNoTracking();
    }

    private bool _disposed;

    protected virtual void Dispose(bool disposing)
    {
        if (_disposed)
        {
            return;
        }

        _context.Dispose();

        _disposed = true;
    }

    ~ReadOnlyRepository()
    {
        Dispose(false);
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}