using Microsoft.AspNetCore.Mvc;
using Projeto_Cadastro_MVC_3DSTB.Models;
using System.Diagnostics;

namespace Projeto_Cadastro_MVC_3DSTB.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
