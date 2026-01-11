using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _PortfolioComponentPartial : ViewComponent
    {
        private readonly MyPortfolioContext context;

        public _PortfolioComponentPartial(MyPortfolioContext context)
        {
            this.context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = context.Portfolios.ToList();
            return View(values);
        }
    }
}