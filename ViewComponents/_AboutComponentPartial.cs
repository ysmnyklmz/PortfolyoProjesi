using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using System.Linq;

namespace MyPortfolio.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            // Experiences değil, Abouts tablosunu çekiyoruz.
            var values = context.Abouts.ToList(); 
            return View(values);
        }
    }
}