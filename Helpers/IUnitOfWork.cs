using System.Data;
using System.Threading.Tasks;

namespace SpaceBlogBackend.Helpers;

public interface IUnitOfWork
{
    public void BeginTransaction();
    public void BeginTransaction(IsolationLevel isolationLevel);
    public void CommitTransaction();
    public void RollbackTransaction();
    public bool IsTransactionActive();
    public Task<bool> SaveAsync();
    public bool Save();
}