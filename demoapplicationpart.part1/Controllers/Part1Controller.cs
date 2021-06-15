using Microsoft.AspNetCore.Mvc;
using System;

namespace demoapplicationpart.part1.Controllers
{
    public class Part1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
