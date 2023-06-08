using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Comestic_Web.Models
{
    [Table("SanPham")]
    public class SanPham
    {
        [Key]
        [StringLength(5)]
        public string maSP { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string tenSP { get; set; }

        [Required]
        [StringLength(5)]
        public string maLoai { get; set; }

        [Required]
        [StringLength(5)]
        public string maTH { get; set; }

        [Column(TypeName = "ntext")]
        public string moTa { get; set; }

        public int donGia { get; set; }

        public int? soLuong { get; set; }

        [Column(TypeName = "text")]
        public string Anh { get; set; }

        public virtual LoaiSP LoaiSP { get; set; }

        public virtual ThuongHieu ThuongHieu { get; set; }
    
    }
}
