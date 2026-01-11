using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class AboutController : Controller
    {
        private readonly MyPortfolioContext context;

        public AboutController(MyPortfolioContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var values = context.Abouts.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var value = context.Abouts.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            var value = context.Abouts.Update(about);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}