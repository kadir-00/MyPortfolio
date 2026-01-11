using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        private readonly MyPortfolioContext context;

        public _ExperienceComponentPartial(MyPortfolioContext context)
        {
            this.context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
    }
}
