using AutoMapper;
using MediatR;
using N5.Challenge.Application.Dtos;
using N5.Challenge.Application.Interfaces;
using N5.Challenge.Application.Wrappers;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace N5.Challenge.Application.Features.Permission.Query.GetAll
{
    public class PermissionGetAllQuery : IRequest<Response<List<GetAllPermissionsViewModel>>>
    {
        public class PermissionGetAllQueryHandler : IRequestHandler<PermissionGetAllQuery, Response<List<GetAllPermissionsViewModel>>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public PermissionGetAllQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }

            public async Task<Response<List<GetAllPermissionsViewModel>>> Handle(PermissionGetAllQuery request, CancellationToken cancellationToken)
            {
                var permissions = await _unitOfWork.PermissionRepository.GetAllPermissions();
                var result = _mapper.Map<List<GetAllPermissionsViewModel>>(permissions);
                return new Response<List<GetAllPermissionsViewModel>>(result);
            }
        }
    }
}
