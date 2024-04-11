using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class BarberController : Controller
    {
        [Route("barbers/")]
        // GET: BarberController
        public ActionResult Index()
        {
            return View();
        }

    }
}
