using Autofac;
using Intership.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Intership.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly ILifetimeScope lifetimeScope;

		public HomeController(ILogger<HomeController> logger,ILifetimeScope lifetimeScope )
		{
			_logger = logger;
			this.lifetimeScope = lifetimeScope;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult AddStudent()
		{
			var model = lifetimeScope.Resolve<StudentTable>();

			return View(model);
		}

		[HttpPost,ValidateAntiForgeryToken]
		public IActionResult AddStudent(StudentTable studentTable)
		{
			if (ModelState.IsValid)
			{
				studentTable.ResolveDependency(lifetimeScope);

				studentTable.AddStudent(studentTable);
			}
			return View();
		}

		public IActionResult Privacy()
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