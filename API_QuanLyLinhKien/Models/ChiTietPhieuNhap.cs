namespace API_QuanLyLinhKien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietPhieuNhap")]
    public partial class ChiTietPhieuNhap
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MaPN { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MaLK { get; set; }

        public int SoLuong { get; set; }

        public double DonGia { get; set; }

        [Required]
        [StringLength(50)]
        public string DonViTinh { get; set; }

        public bool? status { get; set; }

        public virtual DonViTinh DonViTinh1 { get; set; }

        public virtual LinhKien LinhKien { get; set; }
    }
}
