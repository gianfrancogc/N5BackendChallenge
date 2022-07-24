using Microsoft.EntityFrameworkCore;
using N5.Challenge.Application.Interfaces;
using N5.Challenge.Domain.Entities;
using N5.Challenge.Persistence.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N5.Challenge.Persistence.Repositories
{
    public class PermissionRepository : RepositoryBase<Permission>, IPermissionRepository
    {
        public PermissionRepository(DatabaseDbContext context) : base(context)
        {
        }

        public async Task<List<Permission>> GetAllPermissions()
        {
            return await _context.Permissions.Include(x => x.PermissionType).ToListAsync();
        }
        public async Task<Permission> GetPermissionById(int id)
        {
            return await _context.Permissions.Include(x => x.PermissionType).SingleOrDefaultAsync(x => x.Id==id);
        }
    }
}
