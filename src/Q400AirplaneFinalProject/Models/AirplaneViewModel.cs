using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Q400AirplaneFinalProject.Models
{
    public class AirplaneViewModel
    {
        public  string FirstName { get; set; }
        public string LastName { get; set; }
        public ClimbData SelectedClimbData { get; set; }
        public TakeoffData SelectedTakeOff { get; set; }
         public LandingData SelectedLanding { get; set; }
    }
}
