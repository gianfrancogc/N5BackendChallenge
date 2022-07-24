using AutoMapper;
using MediatR;
using N5.Challenge.Application.Dtos;
using N5.Challenge.Application.Interfaces;
using N5.Challenge.Application.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace N5.Challenge.Application.Features.Permission.Query.GetById
{
    public class PermissionGetByIdQuery : IRequest<Response<GetPermissionViewModel>>
    {
        public int Id { get; set; }

        public class PermissionGetByIdQueryHandler : IRequestHandler<PermissionGetByIdQuery, Response<GetPermissionViewModel>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public PermissionGetByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }

            public async Task<Response<GetPermissionViewModel>> Handle(PermissionGetByIdQuery request, CancellationToken cancellationToken)
            {
                var permission = await _unitOfWork.PermissionRepository.GetPermissionById(request.Id);
                var result = _mapper.Map<GetPermissionViewModel>(permission);
                return new Response<GetPermissionViewModel>(result);
            }
        }
    }
}
