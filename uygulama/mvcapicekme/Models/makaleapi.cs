using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcapicekme.Models
{
    public class makaleapi
    {
        [Key]
        public int Mno { get; set; }

        [StringLength(50)]
        public string baslik { get; set; }

        [StringLength(50)]
        public string metin { get; set; }

    }
}