using Herhaling_Idee_Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using HerhalingIdee_Domain.Business;

namespace Herhaling_Idee_Web.Controllers
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly ILogger<HomeController> _logger;
        private HerhalingIdee_Domain.Business.Controller _controller;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _controller = new HerhalingIdee_Domain.Business.Controller();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AddIdee()
        {
            return View();
        }
        public IActionResult AddIdeetje(IdeePersoon ideetje)
        {
            _controller.addIdee(ideetje);
            return RedirectToAction("AddIdee");
        }
        public IActionResult ShowIdee()
        {
            return View(_controller.getIdeeList());
        }
        public IActionResult DeleteIdee(IdeePersoon ideetje)
        {
            _controller.DeleteIdeeFromDB(ideetje);
            return RedirectToAction("ShowIdee");
        }
        public IActionResult Create()
        {
            return RedirectToAction("AddIdee");
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
