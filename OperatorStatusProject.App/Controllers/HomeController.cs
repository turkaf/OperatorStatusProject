using Microsoft.AspNetCore.Mvc;
using OperatorStatusProject.App.Models;
using System.Diagnostics;

namespace OperatorStatusProject.App.Controllers
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
            var viewModel = new DataViewModel();
            var shiftData = viewModel.shiftData;
            var stances = viewModel.stances;
            return View(viewModel);
        }


    }
}
