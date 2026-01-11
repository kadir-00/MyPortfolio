using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
	public class StatisticController : Controller
	{
		private readonly MyPortfolioContext context;

		public StatisticController(MyPortfolioContext context)
		{
			this.context = context;
		}
		public IActionResult Index()
		{
			ViewBag.v1 = context.Skills.Count();
			ViewBag.v2 = context.Messages.Count();
			ViewBag.v3 = context.Messages.Where(x => x.IsRead == false).Count();
			ViewBag.v4 = context.Messages.Where(x => x.IsRead == true).Count();
			ViewBag.v5 = context.Experiences.Count();//deneyim sayısı
			ViewBag.v6 = context.Portfolios.Count();
			ViewBag.v7 = context.SocialMedias.Count();
			ViewBag.v8 = context.ToDoLists.Count(); //kaç adet işlem var ? 
			ViewBag.v9 = context.Testimonials.Count(); // kaç referans var
			return View();
		}
	}
}
