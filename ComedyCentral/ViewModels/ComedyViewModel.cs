using System;
using System.Collections.Generic;
using ComedyCentral.Models;


namespace ComedyCentral.ViewModels
{
    public class ComedyViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Description { get; set; }
        public IEnumerable<Description> Descriptions { get; set; }
        public DateTime DateTime
        {
            get { return DateTime.Parse(string.Format("{0} {1}", Date, Time)); }
        }
    }
}