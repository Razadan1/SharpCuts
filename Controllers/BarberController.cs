using Microsoft.AspNetCore.Mvc;
using SharpCuts.DAL.Contracts;
using SharpCuts.DAL.MyAppDbContext;
using SharpCuts.DAL.Repo;
using SharpCuts.DTO.BarberDTO;
using SharpCuts.Models;

namespace MyApp.Namespace
{
    public class BarberController : Controller
    {
        public IActionResult Booking()
        {
            // Create a view model and pass it to the view
            var viewModel = new BarberBookingViewModel
            {
                AvailableBarbers = new List<string> { "John", "Jane", "Bob" },
                AvailableTimeSlots = new List<string> { "9:00 AM", "10:30 AM", "12:00 PM" }
            };

            return View(viewModel);
        }
    }
}
