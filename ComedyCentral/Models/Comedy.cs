using System;
using System.ComponentModel.DataAnnotations;

namespace ComedyCentral.Models
{
    public class Comedy
    {
        public int Id { get; set; }

        [Required]
        public ApplicationUser Artist { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public string Venue { get; set; }

        [Required]
        public Description Description { get; set; }
    }
}