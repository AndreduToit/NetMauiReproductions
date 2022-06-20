using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace WebAPI.Controllers
{
    /// <summary>
    /// Manages the standard web server pages
    /// (for testing)
    /// </summary>
    public class HomeController : Controller
    {
        #region fields

        /// <summary>
        /// The manager for querying all routes
        /// </summary>
        private readonly IActionDescriptorCollectionProvider mActionDescriptorCollectionProvider;

        #endregion

        #region ctors

        public HomeController(
            IActionDescriptorCollectionProvider tActionDescriptorCollectionProvider)
        {
            mActionDescriptorCollectionProvider = tActionDescriptorCollectionProvider;
        }

        #endregion

        #region index - tests
        [Route("~/Home/TestMe")]
        [HttpGet]
        public IActionResult TestMe()
        {
            return Content("Home Controller here!");
        }
 
        #endregion


    }

}
