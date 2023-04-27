using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationNicola.Models;
using WebApplicationNicola.Repository;

namespace WebApplicationNicola.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogin _loginUser;

        public HomeController(ILogin logUser)
        {
            _loginUser = logUser;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            var result = _loginUser.AuthenticateUser(username, password);

            if (result)
            {
                ViewBag.username = string.Format("Successfully logged-in", username);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.username = string.Format("Login Failed", username);
                return View();
            }
        }
    }
}