using CmsLayout.Models.Pages;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using System.Web.Mvc;

namespace CmsLayout.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        Injected<LayoutModel> LayoutModel { get; set; }

        public ActionResult Index(StartPage currentPage)
        {
            LayoutModel.Service.Mutable = "Layout: mutated from controller";
            return View(currentPage);
        }
    }
}
