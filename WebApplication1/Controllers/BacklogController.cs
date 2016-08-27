using EasyTracker.Business.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class BacklogController : Controller
    {
        public IActionResult Index()
        {
            //var bug = TaskCreator.CreateBug();
            var bug = TaskCreator.CreateEntity();



            ViewData["Message"] = "Show default bug info";

            return View(bug);
        }
    }
}
