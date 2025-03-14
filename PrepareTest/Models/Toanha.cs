using System.ComponentModel.DataAnnotations;

namespace PrepareTest.Models
{
    public class Toanha
    {
        [Key]
        public string ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Ten { get; set; }

        [MaxLength(300)]
        public string DiaChi { get; set; }

        public ICollection<Canho> Canhos { get; set; }
    }
}
