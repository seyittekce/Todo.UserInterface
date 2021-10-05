using AutoMapper;
using Todo.TaskManagement.Lists;

namespace Todo.TaskManagement
{
    public class TaskManagementApplicationAutoMapperProfile : Profile
    {
        public TaskManagementApplicationAutoMapperProfile()
        {
            CreateMap<Entities.Lists.TdList, TdListDto>();
            CreateMap<TdListDto, CreateUpdateTdTasksDto>();
            CreateMap<CreateUpdateTdTasksDto, Entities.Lists.TdList>(MemberList.Source);
        }
    }
}