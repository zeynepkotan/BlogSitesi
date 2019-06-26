namespace api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("yorum")]
    public partial class yorum
    {
        public int YorumId { get; set; }

        [StringLength(500)]
        public string Icerik { get; set; }

        public int? UyeId { get; set; }

        public int? MakaleId { get; set; }

        public DateTime? Tarih { get; set; }

        public virtual makale makale { get; set; }

        public virtual uye uye { get; set; }
    }
}
