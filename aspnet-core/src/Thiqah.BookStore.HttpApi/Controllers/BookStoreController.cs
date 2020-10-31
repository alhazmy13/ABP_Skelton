using Thiqah.BookStore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Thiqah.BookStore.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class BookStoreController : AbpController
    {
        protected BookStoreController()
        {
            LocalizationResource = typeof(BookStoreResource);
        }
    }
}