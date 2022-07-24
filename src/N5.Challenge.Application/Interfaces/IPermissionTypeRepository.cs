using N5.Challenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5.Challenge.Application.Interfaces
{
    public interface IPermissionTypeRepository : IAsyncRepository<PermissionType>
    {
        Task<IEnumerable<PermissionType>> GetAllPermissionTypes();
        Task<PermissionType> GetPermissionTypeById(int id);
    }
}
