using System.Diagnostics;
using KFTS.Models;
using KFTSBussinesLayer.Concrete;
using KFTSDataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace KFTS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        RolManager rm = new RolManager(new EfRolRepository());

        public IActionResult Profil()
        {
            var values= rm.RolListAll();
            return View(values);
        }
        public IActionResult Varliklarim()
        {
            return View();
        }
        public IActionResult GelirGiderBildirme()
        {
            return View();
        }

        public IActionResult AnalizPaneli()
        {
            return View();
        }
        public IActionResult Islemler()
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
