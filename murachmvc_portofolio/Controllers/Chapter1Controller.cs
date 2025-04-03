using Microsoft.AspNetCore.Mvc;
using murachmvc_portofolio.Models.Chapter1;

namespace murachmvc_portofolio.Controllers
{
    public class Chapter1Controller : Controller
    {
        public IActionResult Details(int id)
        {
            Module module = DB.GetModule(id);
            return View(module);
        }

        public IActionResult List()
        {
            List<Module> modules = DB.GetModules();
            return View(modules);
        }
    }
}
