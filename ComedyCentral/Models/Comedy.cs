using System;
using System.ComponentModel.DataAnnotations;

namespace ComedyCentral.Models
{
    public class Comedy
    {
        public int Id { get; set; }

        public ApplicationUser Artist { get; set; }

        [Required]
        public string ArtistId { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public string Venue { get; set; }

        public Description Description { get; set; }

        [Required]
        public byte DescriptionId { get; set; }
    }
}