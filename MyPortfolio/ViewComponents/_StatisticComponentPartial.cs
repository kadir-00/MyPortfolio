using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        private readonly MyPortfolioContext context;

        public _StatisticComponentPartial(MyPortfolioContext context)
        {
            this.context = context;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Count();
            ViewBag.v3 = context.Experiences.Count();
            ViewBag.v4 = context.Messages.Where(x => x.IsRead == true).Count();
            return View();
        }
    }
}
