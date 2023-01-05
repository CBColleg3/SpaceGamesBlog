using System;
using System.Data;
using System.Threading.Tasks;
using Autofac.Util;
using Microsoft.EntityFrameworkCore;

namespace SpaceBlogBackend.Helpers;

public class UnitOfWork: IDisposable, IUnitOfWork
{
    private readonly DbContext _dc;
    private readonly IServiceProvider _serviceProvider;

    public UnitOfWork(DbContext dc, IServiceProvider serviceProvider)
    {
        _dc = dc;
        _serviceProvider = serviceProvider;
    }

    public void BeginTransaction()
    {
        _dc.Database.BeginTransaction();
    }

    public void BeginTransaction(IsolationLevel isolationLevel)
    {
        _dc.Database.BeginTransaction(isolationLevel);
    }

    public void CommitTransaction()
    {
        _dc.Database.CommitTransaction();
    }

    public void RollbackTransaction()
    {
        _dc.Database.RollbackTransaction();
    }

    public bool IsTransactionActive()
    {
        return _dc.Database.CurrentTransaction != null;
    }

    public async Task<bool> SaveAsync()
    {
        return await _dc.SaveChangesAsync() > 0;
    }

    public bool Save()
    {
        return _dc.SaveChanges() > 0;
    }
    
    private bool _disposed = false;

    protected virtual void Dispose(bool disposing)
    {
        if (!this._disposed)
        {
            if (disposing)
            {
                _dc.Dispose();
            }
        }

        this._disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}