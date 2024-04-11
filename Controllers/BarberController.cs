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
        private readonly IBarber barberRepo;
        public BarberController(IBarber barberRepo)
        {
            this.barberRepo = barberRepo;
        }
        [Route("/barbers/")]
        // GET: BarberController
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var barbers = await barberRepo.GetAllAsync();
            var barberDTOs = new BarberDTO(barbers);
            return View(barberDTOs.barbers);
        }

    }
}
