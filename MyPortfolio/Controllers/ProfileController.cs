using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;
using System.IO;

namespace MyPortfolio.Controllers
{
    public class ProfileController : Controller
    {
        private readonly MyPortfolioContext _context;

        public ProfileController(MyPortfolioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var adminId = HttpContext.Session.GetString("AdminID");
            if (string.IsNullOrEmpty(adminId))
            {
                return RedirectToAction("Login", "Login");
            }

            var values = _context.Admins.Find(int.Parse(adminId));
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> Index(Admin admin, IFormFile? imageFile)
        {
            var adminId = HttpContext.Session.GetString("AdminID");
            if (string.IsNullOrEmpty(adminId))
            {
                return RedirectToAction("Login", "Login");
            }

            var existingAdmin = _context.Admins.Find(int.Parse(adminId));
            if (existingAdmin == null)
            {
                return RedirectToAction("Login", "Login");
            }

            // Update Name, Email, Password
            existingAdmin.NameSurname = admin.NameSurname;
            existingAdmin.Email = admin.Email;
            existingAdmin.Password = admin.Password;

            // Handle Image Upload
            if (imageFile != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(imageFile.FileName);
                var imagename = Guid.NewGuid() + extension;
                var saveLocation = Path.Combine(resource, "wwwroot", "userimage", imagename);

                // Ensure directory exists
                var directoryInfo = new DirectoryInfo(Path.Combine(resource, "wwwroot", "userimage"));
                if (!directoryInfo.Exists)
                {
                    directoryInfo.Create();
                }

                using (var stream = new FileStream(saveLocation, FileMode.Create))
                {
                    await imageFile.CopyToAsync(stream);
                }

                existingAdmin.ImageUrl = imagename;
            }

            _context.Admins.Update(existingAdmin);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
