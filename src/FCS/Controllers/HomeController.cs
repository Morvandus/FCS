using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FCS.Models;
using Microsoft.Extensions.Options;

namespace FCS.Controllers
{
    public class HomeController : Controller
    {
        private readonly WebSettings _webSettings;

        public HomeController(IOptions<WebSettings> webSettingsAccessor)
        {
            _webSettings = webSettingsAccessor.Value;
        }

        public IActionResult Index()
        {         
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Email"] = _webSettings.Email;

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
