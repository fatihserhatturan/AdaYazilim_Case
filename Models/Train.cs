using AdaYazilim_Case.Controllers;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AdaYazilim_Case.Models
{
    public class Train
    {
        public string Ad { get; set; }
        public List<Vagon> Vagonlar { get; set; }
    }
}
