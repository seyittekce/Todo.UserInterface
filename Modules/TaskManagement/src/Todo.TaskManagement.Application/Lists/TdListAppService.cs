using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Todo.TaskManagement.Entities.Lists;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
namespace Todo.TaskManagement.Lists
{
    public class TdListAppService : CrudAppService<Entities.Lists.TdList, TdListDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateTdTasksDto, CreateUpdateTdTasksDto>, ITdListAppService
    {
        private IRepository<TdList> _tdListRepository;
        public TdListAppService(IRepository<TdList, Guid> repository, IRepository<TdList> tdListRepository) : base(repository)
        {
            _tdListRepository = tdListRepository;
        }
        public async Task ChangeOrder(TdListDto tdList)
        {
            var findCurrentList = await _tdListRepository.FindAsync(x => x.Order == tdList.Order);
            if (findCurrentList != null)
            {
                var findSender = await _tdListRepository.FindAsync(x => x.Id == tdList.Id);
                findCurrentList.Order = findSender.Order;
                findSender.Order = tdList.Order;
                await _tdListRepository.UpdateManyAsync(new List<TdList> {findCurrentList,findSender});
            }
        }
    }
}
