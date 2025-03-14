using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PrepareTest.Models
{
    public class Sanpham
    {
        [Key]
        public string IdSP { get; set; }

        [Required]
        [MaxLength(50)]
        public string Ten { get; set; }

        [Required]
        public decimal GiaTien { get; set; }

        public string IdNSX { get; set; }
        [ForeignKey("IdNSX")]
        public Nhasx Nhasx { get; set; }
    }
}
