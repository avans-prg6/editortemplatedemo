using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using editortemplatedemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace editortemplatedemo.Controllers
{
    public class PrognoseController : Controller
    {
        public IActionResult Index()
        {
            var model = new PrognoseWeekVM(7);
            return View(model);
        }

        [HttpPost]
        public IActionResult ChangePrognose(PrognoseWeekVM source)
        {
            return View("PrognoseWeekVM", source);
        }
    }
}
