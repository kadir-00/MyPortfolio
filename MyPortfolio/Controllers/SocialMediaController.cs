using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
	public class SocialMediaController : Controller
	{
		private readonly MyPortfolioContext context;

		public SocialMediaController(MyPortfolioContext context)
		{
			this.context = context;
		}
		public IActionResult Index()
		{
			var values = context.SocialMedias.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult CreateSocialMedia()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateSocialMedia(SocialMedia socialMedia)
		{
			context.SocialMedias.Add(socialMedia);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateSocialMedia(int id)
		{
			var value = context.SocialMedias.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateSocialMedia(SocialMedia socialMedia)
		{
			context.SocialMedias.Update(socialMedia);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult DeleteSocialMedia(int id)
		{
			var value = context.SocialMedias.Find(id);
			context.SocialMedias.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
