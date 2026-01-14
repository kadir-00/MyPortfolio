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
        public async Task<IActionResult> UpdateAbout(About about, IFormFile image)
        {
            if (image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(image.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/hola-master/images/" + imageName;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await image.CopyToAsync(stream);
                about.ImageUrl = imageName;
            }
            context.Abouts.Update(about);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatus(int id)
        {
            var value = context.Abouts.Find(id);
            if (value.Status == true)
            {
                value.Status = false;
            }
            else
            {
                value.Status = true;
            }
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}