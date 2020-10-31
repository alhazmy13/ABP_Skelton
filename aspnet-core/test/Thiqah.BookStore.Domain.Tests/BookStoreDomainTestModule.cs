using Thiqah.BookStore.MongoDB;
using Volo.Abp.Modularity;

namespace Thiqah.BookStore
{
    [DependsOn(
        typeof(BookStoreMongoDbTestModule)
        )]
    public class BookStoreDomainTestModule : AbpModule
    {

    }
}