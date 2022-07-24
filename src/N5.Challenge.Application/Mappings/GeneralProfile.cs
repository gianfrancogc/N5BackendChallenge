using AutoMapper;
using N5.Challenge.Application.Dtos;
using N5.Challenge.Application.Features.Permission.Commands.Create;
using N5.Challenge.Domain.Entities;

namespace N5.Challenge.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<CreatePermissionCommand, Permission>();
            CreateMap<Permission, GetPermissionViewModel>().
                  ForMember(dest =>
        dest.PermissionType,
        opt => opt.MapFrom(src => src.PermissionType.Description));
            CreateMap<PermissionType, PermissionTypeViewModel>();
            CreateMap<Permission, GetAllPermissionsViewModel>().
                ForMember(dest =>
        dest.PermissionType,
        opt => opt.MapFrom(src => src.PermissionType.Description));
        }

    }
}
