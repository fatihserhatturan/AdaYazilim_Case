using Newtonsoft.Json;
using System.Diagnostics;

namespace AdaYazilim_Case.Models
{
    public class ReservationRequest
    {
        public Train Tren { get; set; }
        public int RezervasyonYapilacakKisiSayisi { get; set; }
        public bool KisilerFarkliVagonlaraYerlestirilebilir { get; set; }
    }
}
