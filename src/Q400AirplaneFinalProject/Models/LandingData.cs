using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Q400AirplaneFinalProject.Models
{
    public class LandingData
    {
        public int Flaps { get; set; }
        public int Id { get; set; }

        public int Weight { get; set; }
        [Display(Name = "Above 20")]
        public bool above20 { get; set; }
        [Display(Name = "Altitude")]
        public int Altitude { get; set; }
        [Display(Name = "VR")]
        public int Vr { get; set; }
        [Display(Name = "V2")]
        public int V2 { get; set; }
        public int Vref { get; set; }
        public int Vga { get; set; }
        public int Vapp { get; internal set; }
    }
}
