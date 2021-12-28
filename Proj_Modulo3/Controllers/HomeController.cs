using Microsoft.AspNetCore.Mvc;
using Proj_Modulo3.Models;
using System.Diagnostics;

namespace Proj_Modulo3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult contato()
        {
            return View();
        }

       

        
    }
}