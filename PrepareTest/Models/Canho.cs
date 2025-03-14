using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PrepareTest.Models
{
    public class Canho
    {
        [Key]
        public string ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Ten { get; set; }

        [Required]
        public decimal DienTich { get; set; }

        public string IdToaNha { get; set; }
        [ForeignKey("IdToaNha")]
        public Toanha Toanha { get; set; }
    }
}
