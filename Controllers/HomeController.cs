using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using part1.Models;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace part1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string ip = this.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewData["ip"] = ip;
            string cookie = Request.Cookies[ip];
            if(cookie == null)
            {
                ViewData["visits"] = 1;
                CookieOptions expiry = new CookieOptions();
                expiry.Expires = DateTime.Now.AddYears(2);
                Response.Cookies.Append(ip, "1", expiry);

            }
            else
            {
                int visits = Int32.Parse(cookie);
                visits = visits + 1;
                Response.Cookies.Append(ip, visits.ToString());
                ViewData["visits"] = visits;
            }


            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
