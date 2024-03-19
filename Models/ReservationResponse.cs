using AdaYazilim_Case.Controllers;
using Newtonsoft.Json;

namespace AdaYazilim_Case.Models
{
    public class ReservationResponse
    {
        public bool RezervasyonYapilabilir { get; set; }
        public List<ReservationDetail> YerlesimAyrinti { get; set; }
    }
}
