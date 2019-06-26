namespace api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("makale")]
    public partial class makale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public makale()
        {
            yorum = new HashSet<yorum>();
        }

        public int MakaleId { get; set; }

        [StringLength(50)]
        public string Baslik { get; set; }

        [StringLength(5000)]
        public string Icerik { get; set; }

        [StringLength(100)]
        public string Foto { get; set; }

        public DateTime? Tarih { get; set; }

        public int? KategoriId { get; set; }

        public int? UyeId { get; set; }

        public int? OkunmaSayisi { get; set; }

        public virtual kategori kategori { get; set; }

        public virtual uye uye { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<yorum> yorum { get; set; }
    }
}
