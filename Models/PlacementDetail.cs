using Newtonsoft.Json;

namespace AdaYazilim_Case.Models
{
    public class PlacementDetail
    {
        [JsonProperty("VagonAdi")]
        public string WagonName { get; set; }

        [JsonProperty("KisiSayisi")]
        public int PersonCount { get; set; }
    }
}
