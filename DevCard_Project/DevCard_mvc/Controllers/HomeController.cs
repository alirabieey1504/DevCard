using System.Collections.Generic;
using DevCard_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DevCard_mvc.Controllers
{
    public class HomeController : Controller
    {
      //  public List<Matn> pro = new List<Matn>();
        public HomeController()
        {
        }
       
        public IActionResult Index()
        {
           // Matn.Id = "";
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}