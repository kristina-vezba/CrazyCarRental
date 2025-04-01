﻿using System.ComponentModel.DataAnnotations;

namespace CrazyCarRental.Models
{
	public class Booking
	{
		public int BookingId { get; set; }
		public int CarId { get; set; }
		public int UserId { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public decimal TotalPrice { get; set; }
	}
}
