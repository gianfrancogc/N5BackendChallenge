using N5.Challenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5.Challenge.Application.Interfaces
{
    public interface IPermissionRepository : IAsyncRepository<Permission>
    {
        Task<List<Permission>> GetAllPermissions();
        Task<Permission> GetPermissionById(int id);
    }
}
