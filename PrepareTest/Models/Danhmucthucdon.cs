using System.ComponentModel.DataAnnotations;

namespace PrepareTest.Models
{
    public class Danhmucthucdon
    {
        [Key]
        public string MaDanhMuc { get; set; }

        [Required]
        [MaxLength(50)]
        public string TenDanhMuc { get; set; }

        public ICollection<Monan> Monans { get; set; }
    }
}
