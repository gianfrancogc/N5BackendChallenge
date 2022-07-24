using AutoMapper;
using MediatR;
using N5.Challenge.Application.Dtos;
using N5.Challenge.Application.Interfaces;
using N5.Challenge.Application.Wrappers;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace N5.Challenge.Application.Features.PermissionType.Query
{
    public class PermissionTypeGetAllQuery : IRequest<Response<List<PermissionTypeViewModel>>>
    {
        public class PermissionTypeGetAllQueryHandler : IRequestHandler<PermissionTypeGetAllQuery, Response<List<PermissionTypeViewModel>>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public PermissionTypeGetAllQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }

            public async Task<Response<List<PermissionTypeViewModel>>> Handle(PermissionTypeGetAllQuery request, CancellationToken cancellationToken)
            {
                var permissionsTypes = await _unitOfWork.PermissionTypeRepository.GetAllAsync();
                var result = _mapper.Map<List<PermissionTypeViewModel>>(permissionsTypes);
                return new Response<List<PermissionTypeViewModel>>(result);
            }
        }
    }
}
