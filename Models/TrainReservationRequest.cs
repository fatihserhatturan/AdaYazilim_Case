using Newtonsoft.Json;
using System.Diagnostics;

namespace AdaYazilim_Case.Models
{
    public class TrainReservationRequest
    {
        [JsonProperty("Tren")]
        public Train Train { get; set; }

        [JsonProperty("RezervasyonYapilacakKisiSayisi")]
        public int ReservationPersonCount { get; set; }

        [JsonProperty("KisilerFarkliVagonlaraYerlestirilebilir")]
        public bool CanPeopleBePlacedInDifferentWagons { get; set; }
    }
}
