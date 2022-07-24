using MediatR;
using N5.Challenge.Application.Exceptions;
using N5.Challenge.Application.Interfaces;
using N5.Challenge.Application.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace N5.Challenge.Application.Features.Permission.Commands.Update
{
    public class UpdatePermissionCommand : IRequest<Response<int>>
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeLastname { get; set; }
        public int PermissionTypeId { get; set; }
        public class UpdatePermissionCommandHandler : IRequestHandler<UpdatePermissionCommand, Response<int>>
        {
            private readonly IUnitOfWork _unitOfWork;
            public UpdatePermissionCommandHandler(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }
            public async Task<Response<int>> Handle(UpdatePermissionCommand command, CancellationToken cancellationToken)
            {
                var permission = await _unitOfWork.PermissionRepository.GetByIdAsync(command.Id);

                if (permission == null)
                {
                    throw new ApiException($"Permission Not Found.");
                }
                else
                {
                    permission.EmployeeName = command.EmployeeName;
                    permission.EmployeeLastname = command.EmployeeLastname;
                    permission.PermissionTypeId = command.PermissionTypeId;
                    await _unitOfWork.PermissionRepository.UpdateAsync(permission);
                    return new Response<int>(permission.Id,"Actualizado correctamente");
                }
            }
        }
    }
}
