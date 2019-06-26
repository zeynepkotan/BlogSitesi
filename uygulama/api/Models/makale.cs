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
        [Key]
        public int Mno { get; set; }

        [StringLength(50)]
        public string baslik { get; set; }

        [StringLength(50)]
        public string metin { get; set; }

        [StringLength(50)]
        public string resimAdres { get; set; }

        public DateTime? Eklemetarihi { get; set; }

        public DateTime? yazildigitarih { get; set; }

        [StringLength(50)]
        public string eklendigiIp { get; set; }

        public int? YNo { get; set; }

        public int? Kno { get; set; }

        public bool? Aktifmi { get; set; }

        public virtual kategori kategori { get; set; }

        public virtual yazar yazar { get; set; }
    }
}
