using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PrepareTest.Models
{
    public class Monan
    {
        [Key]
        public string ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string TenMon { get; set; }

        [Required]
        public decimal GiaTien { get; set; }

        [Required]
        [MaxLength(300)]
        public string NguyenLieuChinh { get; set; }

        public string MaDanhMuc { get; set; }
        [ForeignKey("MaDanhMuc")]
        public Danhmucthucdon Danhmucthucdon { get; set; }
    }
}
