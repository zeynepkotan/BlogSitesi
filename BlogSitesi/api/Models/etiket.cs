namespace api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("etiket")]
    public partial class etiket
    {
        public int EtiketId { get; set; }

        [StringLength(50)]
        public string EtiketAdi { get; set; }
    }
}
