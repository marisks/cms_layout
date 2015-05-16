using EPiServer.ServiceLocation;
using System.Web.Mvc;

namespace CmsLayout.Models.Pages
{
    public class BaseViewPage : WebViewPage
    {
        public Injected<LayoutModel> LayoutModel { get; set; }

        public override void Execute()
        {

        }
    }
}
