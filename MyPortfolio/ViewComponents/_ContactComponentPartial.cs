using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        private readonly MyPortfolioContext context;

        public _ContactComponentPartial(MyPortfolioContext context)
        {
            this.context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = context.Contacts.ToList();
            return View(values);
        }
    }
}