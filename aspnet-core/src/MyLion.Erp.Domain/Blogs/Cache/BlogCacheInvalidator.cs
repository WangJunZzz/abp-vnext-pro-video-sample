using MyLion.Erp.Blogs.Aggregates;
using MyLion.Erp.Blogs.Dto;
using Volo.Abp.Caching;
using Volo.Abp.Domain.Entities.Events;
using Volo.Abp.EventBus;

namespace MyLion.Erp.Blogs.Cache;

public class BlogCacheInvalidator : ILocalEventHandler<EntityChangedEventData<Blog>>, ITransientDependency
{
    private readonly IDistributedCache<BlogDto> _distributedCache;

    public BlogCacheInvalidator(IDistributedCache<BlogDto> distributedCache)
    {
        _distributedCache = distributedCache;
    }

    public async Task HandleEventAsync(EntityChangedEventData<Blog> eventData)
    {
        await _distributedCache.RemoveAsync(eventData.Entity.Name);
    }
}