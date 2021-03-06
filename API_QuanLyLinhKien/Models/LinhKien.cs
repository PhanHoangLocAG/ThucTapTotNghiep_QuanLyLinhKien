namespace API_QuanLyLinhKien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LinhKien")]
    public partial class LinhKien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LinhKien()
        {
            ChiTietHDs = new HashSet<ChiTietHD>();
            ChiTietPhieuNhaps = new HashSet<ChiTietPhieuNhap>();
            ChiTietPhieuXuats = new HashSet<ChiTietPhieuXuat>();
        }

        [Key]
        [StringLength(50)]
        public string MaLK { get; set; }

        [Required]
        [StringLength(50)]
        public string MaLoai { get; set; }

        [Required]
        [StringLength(50)]
        public string MaNCC { get; set; }

        [Required]
        [StringLength(100)]
        public string TenLK { get; set; }

        [Column(TypeName = "text")]
        public string MoTa { get; set; }

        [StringLength(50)]
        public string Hinh { get; set; }

        [Required]
        [StringLength(50)]
        public string HangSX { get; set; }

        public double? GiaBan { get; set; }

        public bool? status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHD> ChiTietHDs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuXuat> ChiTietPhieuXuats { get; set; }

        public virtual HangSX HangSX1 { get; set; }

        public virtual LoaiLK LoaiLK { get; set; }

        public virtual NhaCC NhaCC { get; set; }
    }
}
