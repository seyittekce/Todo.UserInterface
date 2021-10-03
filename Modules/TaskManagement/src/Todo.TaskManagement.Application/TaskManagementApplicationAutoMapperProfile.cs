using AutoMapper;
using Todo.TaskManagement.Lists;

namespace Todo.TaskManagement
{
    public class TaskManagementApplicationAutoMapperProfile : Profile
    {
        public TaskManagementApplicationAutoMapperProfile()
        {
            CreateMap<Entities.Lists.TdList, TdListDto>();
            CreateMap<TdListDto, CreateUpdateTdListDto>();
            CreateMap<CreateUpdateTdListDto, Entities.Lists.TdList>(MemberList.Source);
        }
    }
}