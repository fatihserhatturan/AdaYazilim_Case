using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AdaYazilim_Case.Models
{
    public class Train
    {
        [Key]
        public int TrainId { get; set; }

        [JsonProperty("Ad")]
        public string Name { get; set; }

        [JsonProperty("Vagonlar")]
        public List<Wagon> Wagons { get; set; }
    }
}
