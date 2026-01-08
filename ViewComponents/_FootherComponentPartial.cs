using Microsoft.AspNetCore.Mvc;
namespace MyPortfolio.ViewComponents
{
    public class _FootherComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}