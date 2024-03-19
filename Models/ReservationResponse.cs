using Newtonsoft.Json;

namespace AdaYazilim_Case.Models
{
    public class ReservationResponse
    {
        [JsonProperty("RezervasyonYapilabilir")]
        public bool IsReservationPossible { get; set; }

        [JsonProperty("YerlesimAyrinti")]
        public List<PlacementDetail> PlacementDetails { get; set; }
    }
}
