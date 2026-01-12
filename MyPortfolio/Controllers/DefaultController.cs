using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        private readonly MyPortfolioContext context;

        public DefaultController(MyPortfolioContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(string contactName, string contactEmail, string contactSubject, string contactMessage)
        {
            Message message = new Message();
            message.NameSurname = contactName;
            message.Email = contactEmail;
            message.Subject = contactSubject;
            message.MessageDetail = contactMessage;
            message.SendDate = DateTime.Now;
            message.IsRead = false;
            context.Messages.Add(message);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
