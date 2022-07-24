using N5.Challenge.Domain;
using System;
using System.Threading.Tasks;

namespace N5.Challenge.Application.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
     
        IAsyncRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity;
        Task<int> Done();

        #region Repositories
        IPermissionRepository PermissionRepository { get; }
        IPermissionTypeRepository PermissionTypeRepository { get; }
        #endregion

    }
}
