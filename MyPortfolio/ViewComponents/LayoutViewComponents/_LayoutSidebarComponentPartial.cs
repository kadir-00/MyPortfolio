using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents.LayoutViewComponents
{
    public class _LayoutSidebarComponentPartial : ViewComponent
    {
        private readonly MyPortfolioContext context;

        public _LayoutSidebarComponentPartial(MyPortfolioContext context)
        {
            this.context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = context.Admins.ToList();
            return View(values);
        }
    }
}
