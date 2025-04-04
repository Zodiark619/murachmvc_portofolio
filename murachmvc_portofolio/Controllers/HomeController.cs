using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using murachmvc_portofolio.Models;
using murachmvc_portofolio.Models.Chapter2;

namespace murachmvc_portofolio.Controllers
{
    public class HomeController : Controller
    {
        #region comment
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

       

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
        #endregion


        public IActionResult Index()
        {
            return View();
        }

        #region Chapter1
        [HttpGet]
        public IActionResult Chapter1()
        {
            return View();
        }
        #endregion
        #region Chapter2

        [HttpGet]
        public IActionResult Chapter2()
        {
         
            ViewBag.Modules=DB.GetTFDGachas();
        
            return View();
        }

        [HttpPost]
        public IActionResult Chapter2(int id)
        {
          
            var model = DB.GetTFDGacha(id);
            ViewBag.Message= DB.TFDGacha_Execute(model);
            var message1=new List<string>();
            for(int i = 0; i <= 4; i++)
            {
                message1.Add($"{model.Items[i]}: {model.Rarities[i]}%");
            }
            ViewBag.Message1 = message1;
            ViewBag.Modules = DB.GetTFDGachas();

            return View(model);
        }
        #endregion


        //[HttpGet]
        //public IActionResult Chapter3()
        //{
        //    return View();
        //}
        //[HttpGet]
        //public IActionResult Chapter4A()
        //{
        //    return View();
        //}
        //[HttpGet]
        //public IActionResult Chapter4B()
        //{
        //    return View();
        //}








    }
}
