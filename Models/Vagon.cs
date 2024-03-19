using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AdaYazilim_Case.Models
{
    public class Vagon
    {
        public string Ad { get; set; }
        public int Kapasite { get; set; }
        public int DoluKoltukAdet { get; set; }
    }
}
