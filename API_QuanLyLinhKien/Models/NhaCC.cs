namespace API_QuanLyLinhKien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhaCC")]
    public partial class NhaCC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhaCC()
        {
            LinhKiens = new HashSet<LinhKien>();
        }

        [Key]
        [StringLength(50)]
        public string MaNCC { get; set; }

        [Required]
        [StringLength(100)]
        public string TenNCC { get; set; }

        public bool? status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LinhKien> LinhKiens { get; set; }
    }
}
