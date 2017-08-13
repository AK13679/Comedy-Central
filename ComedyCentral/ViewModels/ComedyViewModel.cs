using System.Collections.Generic;
using ComedyCentral.Models;


namespace ComedyCentral.ViewModels
{
    public class ComedyViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Description { get; set; }
        public IEnumerable<Description> Descriptions { get; set; }
    }
}