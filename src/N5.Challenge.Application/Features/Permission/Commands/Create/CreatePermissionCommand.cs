using AutoMapper;
using MediatR;
using N5.Challenge.Application.Interfaces;
using N5.Challenge.Application.Wrappers;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace N5.Challenge.Application.Features.Permission.Commands.Create
{
    public class CreatePermissionCommand : IRequest<Response<int>>
    {
        public string EmployeeName { get; set; }
        public string EmployeeLastname { get; set; }
        public int PermissionTypeId { get; set; }
        public DateTime PermissionDate { get; set; }

    }

    public class CreatePermissionCommandHandler : IRequestHandler<CreatePermissionCommand, Response<int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CreatePermissionCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(CreatePermissionCommand request, CancellationToken cancellationToken)
        {
            var entry = _mapper.Map<N5.Challenge.Domain.Entities.Permission>(request);
            await _unitOfWork.PermissionRepository.AddAsync(entry);
            return new Response<int>(entry.Id,"Registro ingresado correctamente");
        }
    }
}
