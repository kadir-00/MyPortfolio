using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _SocialMediaComponentPartial : ViewComponent
    {
        private readonly MyPortfolioContext context;

        public _SocialMediaComponentPartial(MyPortfolioContext context)
        {
            this.context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = context.SocialMedias.ToList();
            return View(values);
        }
    }
}
