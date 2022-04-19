using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MuaBanPC_LapTop.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MuaBanPC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult TrangChu()
        {
            return View();
        }

        public IActionResult DMSP()
        {
            return View();
        }
        public IActionResult Video()
        {
            return View();
        }
        public IActionResult Tintuc()
        {
            return View();
        }
        public IActionResult DonHang()
        {
            return View();
        }
        public IActionResult DangKy()
        {
            return View();
        }
        public IActionResult PC()
        {
            return View();
        }
        public IActionResult PCVanPhong()
        {
            return View();
        }
        public IActionResult PCGaming()
        {
            return View();
        }
        public IActionResult PCWorkstation()
        {
            return View();
        }
        public IActionResult PCMiNi()
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
