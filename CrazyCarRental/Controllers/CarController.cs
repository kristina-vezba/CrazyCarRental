using CrazyCarRental.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrazyCarRental.Controllers
{
	public class CarController : Controller
	{

		public IActionResult Index()
		{
			var cars = InitCars();

			return View(cars);
		}

		public IActionResult Details(int id)
		{
			var cars = InitCars();
			var car = cars.FirstOrDefault(c => c.CarId == id);

			if (car == null) 
				return NotFound();

			return View(car);
		}

		//public IActionResult Index(string make, string model, decimal? minPrice, decimal? maxPrice)
		//{

		//	var cars = InitCars();
		//	// Filter by make
		//	if (!string.IsNullOrEmpty(make))
		//	{
		//		cars = cars.Where(c => c.Make.ToLower().Contains(make.ToLower()));
		//	}

		//	// Filter by model
		//	if (!string.IsNullOrEmpty(model))
		//	{
		//		cars = cars.Where(c => c.Model.Contains(model));
		//	}

		//	// Filter by price range
		//	if (minPrice.HasValue)
		//	{
		//		cars = cars.Where(c => c.PricePerDay >= minPrice.Value);
		//	}
		//	if (maxPrice.HasValue)
		//	{
		//		cars = cars.Where(c => c.PricePerDay <= maxPrice.Value);
		//	}

		//	return View(cars);
		//}

		private IEnumerable<Car> InitCars()
		{
			var cars = new List<Car>();
			Car lancerEvo6 = new Car()
			{
				CarId = 1,
				Make = "Mitsubishi",
				Model = "Lancer Evo VI",
				Year = 1999,
				PricePerDay = 224.5m,
				ImageUrl = "mitsubishi-evo-6-1999.jpg",
				Seats = 5
			};

			Car imprezaSti = new Car()
			{
				CarId = 2,
				Make = "Subaru",
				Model = "Impreza WRX Sti",
				Year = 2006,
				PricePerDay = 213.98m,
				Seats = 5,
				ImageUrl = "subaru-impreza-wrx-sti-2006.jpg",
				IsAvailable = true
			};

			Car lanciaDelta = new Car()
			{
				CarId = 3,
				Make = "Lancia",
				Model = "Delta HF Integrale",
				Year = 1992,
				PricePerDay = 350.78m,
				Seats = 5,
				ImageUrl = "Lancia-delta-1992.jpg",
				IsAvailable = false
			};

			Car audiQuattro = new Car()
			{
				CarId = 4,
				Make = "Audi",
				Model = "Quattro",
				Year = 1980,
				PricePerDay = 400.78m,
				Seats = 5,
				ImageUrl = "Audi-quattro-1980.jpg",
				IsAvailable = true
			};

			cars.Add(lancerEvo6);
			cars.Add(imprezaSti);
			cars.Add(lanciaDelta);
			cars.Add(audiQuattro);

			return cars;
		}
	}
}
