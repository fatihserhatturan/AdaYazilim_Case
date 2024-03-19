using AdaYazilim_Case.Models;
using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdaYazilim_Case.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly ReservationService _reservationService;

        public ReservationController(ReservationService reservationService)
        {
            _reservationService = reservationService;
        }


        [HttpPost]
        public IActionResult MakeReservation(TrainReservationRequest request)
        {
            var response = _reservationService.MakeReservation(request);

            return Ok(response);
        }

    }
}
