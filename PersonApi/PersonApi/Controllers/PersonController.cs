using Microsoft.AspNetCore.Mvc;

namespace PersonApi.Controllers
{
	public class PersonController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
