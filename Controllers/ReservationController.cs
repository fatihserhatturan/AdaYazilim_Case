using AdaYazilim_Case.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdaYazilim_Case.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReservationController : Controller
    {
        private readonly ReservationService _reservationService;

        public ReservationController(ReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpPost]
        public IActionResult MakeReservation([FromBody] ReservationRequest request)
        {
            if (request == null)
            {
                return BadRequest("Geçersiz istek formatı.");
            }

            var response = _reservationService.MakeReservation(request);
            return Ok(response);
        }
    }
  
}

