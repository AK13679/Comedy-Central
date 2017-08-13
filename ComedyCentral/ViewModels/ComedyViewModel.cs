using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ComedyCentral.Models;


namespace ComedyCentral.ViewModels
{
    public class ComedyViewModel
    {
        [Required]
        public string Venue { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }

        [Required]
        [ValidTime]
        public string Time { get; set; }

        [Required]
        public byte Description { get; set; }

        public IEnumerable<Description> Descriptions { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time)); 
        }
    }
}