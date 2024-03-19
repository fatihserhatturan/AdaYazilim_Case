using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AdaYazilim_Case.Models
{
    public class Wagon
    {
        [Key]
        public int WagonId { get; set; }

        [JsonProperty("Ad")]
        public string Name { get; set; }

        [JsonProperty("Kapasite")]
        public int Capacity { get; set; }

        [JsonProperty("DoluKoltukAdet")]
        public int OccupiedSeatCount { get; set; }
        public Train Train { get; set; }
    }
}
