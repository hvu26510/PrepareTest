using System.ComponentModel.DataAnnotations;

namespace PrepareTest.Models
{
    public class Nhasx
    {
        [Key]
        public string IdNSX { get; set; }

        [Required]
        [MaxLength(50)]
        public string Ten { get; set; }

        [MaxLength(300)]
        public string DiaChi { get; set; }

        public ICollection<Sanpham> Sanphams { get; set; }
    }
}
