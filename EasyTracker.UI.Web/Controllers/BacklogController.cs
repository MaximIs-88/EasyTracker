using EasyTracker.Business.Entities;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyTracker.UI.Web.Controllers
{
    public class BacklogController : Controller
    {
        public IActionResult Index()
        {
            var bug = TaskCreator.CreateBug();

            ViewData["Message"] = "Show default bug info";

            return View(bug);
        }
    }
}
