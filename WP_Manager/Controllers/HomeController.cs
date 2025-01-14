using Microsoft.AspNetCore.Mvc;
using Models;
using System.Diagnostics;

namespace WP_Manager.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            return View("/Pages/Index.cshtml");
        }

        [HttpGet("/BackOffice")]
        public IActionResult BackOffice()
        {
            //var users = dbContext.User.ToList();

            //ViewBag.Users = users;

            return View("/Pages/BackOffice.cshtml");
        }
    }
}
