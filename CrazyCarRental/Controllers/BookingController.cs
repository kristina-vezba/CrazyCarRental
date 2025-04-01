using Microsoft.AspNetCore.Mvc;

namespace CrazyCarRental.Controllers
{
	public class BookingController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Booking()
		{
			return View();
		}

		public IActionResult ConfirmBooking()
		{
			return View();
		}

		public IActionResult BookingHistory()
		{
			return View();
		}

		public IActionResult Return()
		{
			return View();
		}
	}
}
