using System.ComponentModel.DataAnnotations;
namespace ComedyCentral.Models
{
    public class Description
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}