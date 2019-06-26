using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using api.Models;
namespace api.Controllers
{
    public class UyeCekController : ApiController
    {

        Blog db = new Blog();


        [HttpGet]
        [Nitelik.Log]

        public IHttpActionResult Hareket()
        {


            var uyeListe = db.uye.Select(p => new { p.AdSoyad });


            return Json(uyeListe);
        }



        [HttpPost]
        [Nitelik.Log]
        public IHttpActionResult HareketPost(string Bilet, string degisken2)
        {

            var form = Request.Content.ReadAsStringAsync();
            var UyeAdi = Request.Headers.GetValues("uye").ToList()[0];


            var UyeListe = db.uye.Where(s => s.AdSoyad == UyeAdi)
                                 .Select(p => new { p.AdSoyad });

            return Json(UyeListe);
        }
    }
}
