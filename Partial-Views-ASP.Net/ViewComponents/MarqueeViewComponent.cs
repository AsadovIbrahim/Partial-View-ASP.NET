using Microsoft.AspNetCore.Mvc;

namespace Partial_Views_ASP.Net.ViewComponents
{
    public class MarqueeViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var datas = new List<string>()
            {
                "DIZAYN",
                "PROQRAMLAŞDIRMA",
                "KIBER TƏHLÜKƏSİZLİK",
                "UŞAQLAR ÜÇÜN IT"
            };
            return View(datas);
        }
    }
}
