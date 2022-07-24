using Microsoft.EntityFrameworkCore;
using N5.Challenge.Application.Interfaces;
using N5.Challenge.Domain.Entities;
using N5.Challenge.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5.Challenge.Persistence.Repositories
{
    public class PermissionTypeRepository : RepositoryBase<PermissionType>, IPermissionTypeRepository
    {
        public PermissionTypeRepository(DatabaseDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<PermissionType>> GetAllPermissionTypes()
        {
            return await _context.PermissionTypes.ToListAsync();
        }

        public async Task<PermissionType> GetPermissionTypeById(int id)
        {
            return await _context.PermissionTypes.Where(x => x.Id == id).FirstOrDefaultAsync();
        }


    }
}
