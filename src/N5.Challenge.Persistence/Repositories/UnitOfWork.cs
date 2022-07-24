using N5.Challenge.Application.Interfaces;
using N5.Challenge.Domain;
using N5.Challenge.Persistence.Context;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5.Challenge.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private Hashtable _repositories;
        private readonly DatabaseDbContext _context;

        private IPermissionRepository _permissionRepository;
        private IPermissionTypeRepository _permissionTypeRepository;


        public IPermissionRepository PermissionRepository => _permissionRepository ??= new PermissionRepository(_context);

        public IPermissionTypeRepository PermissionTypeRepository => _permissionTypeRepository ??= new PermissionTypeRepository(_context);

        public UnitOfWork(DatabaseDbContext context)
        {
            _context = context;
        }

        public async Task<int> Done()
        {
           return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IAsyncRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity
        {
            if (_repositories == null)
            {
                _repositories = new Hashtable();
            }

            var type = typeof(TEntity).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(RepositoryBase<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _context);
                _repositories.Add(type, repositoryInstance);
            }

            return (IAsyncRepository<TEntity>)_repositories[type];
        }


    }
}
