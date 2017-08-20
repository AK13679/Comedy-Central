using System.Collections.Generic;
using ComedyCentral.Models;

namespace ComedyCentral.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Comedy> UpcomingShows { get; set; }
        public bool ShowActions { get; set; }
    }
}