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

		public async Task<IActionResult> Index()
		{
            var model = lifetimeScope.Resolve<StudentTable>();

            var items = await model.GetAll();

			return View(items);
		}

		[HttpGet]
		public IActionResult AddStudent()
		{
			var model = lifetimeScope.Resolve<StudentTable>();

			return View(model);
		}

		[HttpPost,ValidateAntiForgeryToken]
		public async Task<IActionResult> AddStudent(StudentTable studentTable)
		{
			if (ModelState.IsValid)
			{
				studentTable.ResolveDependency(lifetimeScope);

				await studentTable.AddStudent(studentTable);
			}
			return RedirectToAction("Index");
		}

        [HttpGet]
        public async Task<IActionResult> UpdateStudent(Guid Id)
        {
            var model = lifetimeScope.Resolve<StudentTable>();

			var item = await model.GetStudent(Id);

            return View(item);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateStudent(StudentTable studentTable)
        {
            if (ModelState.IsValid)
            {
                studentTable.ResolveDependency(lifetimeScope);

                await studentTable.Update(studentTable);
            }
            return RedirectToAction("Index");
        }
		public async Task<IActionResult> Delete(Guid Id)
		{
			var model = lifetimeScope.Resolve<StudentTable>();

			await model.Delete(Id);

			return RedirectToAction("Index");
		}

        public async Task<IActionResult> Details(Guid Id)
        {
            var model = lifetimeScope.Resolve<StudentTable>();

            var item = await model.GetStudent(Id);

            return View(item);
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