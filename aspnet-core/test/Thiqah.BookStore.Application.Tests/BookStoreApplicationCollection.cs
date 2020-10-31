using Thiqah.BookStore.MongoDB;
using Xunit;

namespace Thiqah.BookStore
{
    [CollectionDefinition(BookStoreTestConsts.CollectionDefinitionName)]
    public class BookStoreApplicationCollection : BookStoreMongoDbCollectionFixtureBase
    {

    }
}
