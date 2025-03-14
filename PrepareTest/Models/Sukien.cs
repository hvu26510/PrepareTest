using System.ComponentModel.DataAnnotations;

namespace PrepareTest.Models
{
    public class Sukien
    {
        [Key]
        public string ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Ten { get; set; }

        [Required]
        public DateTime NgayToChuc { get; set; }

        [MaxLength(300)]
        public string DiaDiem { get; set; }

        public ICollection<Ve> Ve { get; set; }
    }
}
