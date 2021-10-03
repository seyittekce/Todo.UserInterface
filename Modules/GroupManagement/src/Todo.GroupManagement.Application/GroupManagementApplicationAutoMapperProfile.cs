using AutoMapper;
using Todo.GroupManagement.Group;
using Todo.GroupManagement.Entities;
namespace Todo.GroupManagement
{
    public class GroupManagementApplicationAutoMapperProfile : Profile
    {
        public GroupManagementApplicationAutoMapperProfile()
        {
            CreateMap<Entities.Group, GroupDto>();
            CreateMap<GroupDto, CreateUpdateGroupDto>();
            CreateMap<CreateUpdateGroupDto, Entities.Group>(MemberList.Source);
        }
    }
}