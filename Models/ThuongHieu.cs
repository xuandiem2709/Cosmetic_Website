using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Comestic_Web.Models
{
    [Table("ThuongHieu")]
    public class ThuongHieu
    {
        public ThuongHieu()
        {
            SanPham = new HashSet<SanPham>();
        }

        [Key]
        [StringLength(5)]
        public string maTH { get; set; }

        [Required]
        [StringLength(50)]
        public string tenTH { get; set; }

        [Column(TypeName = "ntext")]
        public string moTa { get; set; }
        public virtual ICollection<SanPham> SanPham { get; set; }
    }
}
