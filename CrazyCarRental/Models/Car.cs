﻿using System.ComponentModel.DataAnnotations;

namespace CrazyCarRental.Models
{
	public class Car
	{
		public int CarId { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public decimal PricePerDay { get; set; }
		public bool IsAvailable { get; set; }
		public int Year { get; set; }
		public int Seats { get; set; }
		public string FuelType { get; set; }
		public string ImageUrl { get; set; }
	}
}
