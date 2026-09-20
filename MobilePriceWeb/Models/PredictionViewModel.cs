
using System.ComponentModel.DataAnnotations;

namespace MobilePriceWeb.Models
{
    public class PredictionViewModel
    {
        [Display(Name = "Battery Power")]
        public float Battery_power { get; set; }

        [Display(Name = "Bluetooth")]
        public float Blue { get; set; }

        [Display(Name = "Clock Speed")]
        public float Clock_speed { get; set; }

        [Display(Name = "Dual SIM")]
        public float Dual_sim { get; set; }

        [Display(Name = "Front Camera")]
        public float Fc { get; set; }

        [Display(Name = "4G")]
        public float Four_g { get; set; }

        [Display(Name = "Internal Memory")]
        public float Int_memory { get; set; }

        [Display(Name = "Mobile Depth")]
        public float M_dep { get; set; }

        [Display(Name = "Mobile Weight")]
        public float Mobile_wt { get; set; }

        [Display(Name = "Number of Cores")]
        public float N_cores { get; set; }

        [Display(Name = "Primary Camera")]
        public float Pc { get; set; }

        [Display(Name = "Pixel Height")]
        public float Px_height { get; set; }

        [Display(Name = "Pixel Width")]
        public float Px_width { get; set; }

        [Display(Name = "RAM")]
        public float Ram { get; set; }

        [Display(Name = "Screen Height")]
        public float Sc_h { get; set; }

        [Display(Name = "Screen Width")]
        public float Sc_w { get; set; }

        [Display(Name = "Talk Time")]
        public float Talk_time { get; set; }

        [Display(Name = "3G")]
        public float Three_g { get; set; }

        [Display(Name = "Touch Screen")]
        public float Touch_screen { get; set; }

        [Display(Name = "WiFi")]
        public float Wifi { get; set; }

        public string? Result { get; set; }
    }
}