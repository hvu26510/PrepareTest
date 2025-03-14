using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PrepareTest.Models
{
    public class Ve
    {
        [Key]
        public string MaVe { get; set; }

        [Required]
        [MaxLength(50)]
        public string LoaiVe { get; set; }

        [Required]
        public decimal GiaVe { get; set; }

        public string MaSuKien { get; set; }
        [ForeignKey("MaSuKien")]
        public Sukien Sukien { get; set; }
    }
}
