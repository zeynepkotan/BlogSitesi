using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using api.Models;
using System.Web.Http.Cors;

namespace api.Controllers
{
    [EnableCors("*","*","*")]
    public class makaleController : ApiController
    {
        Makalee db = new Makalee();


        [HttpGet]
        [Nitelik.Log]
        
        public IHttpActionResult Hareket()
        {


            var hareketListe = db.makale.Select(p => new { p.Mno, p.baslik,p.metin });
                
       
            return Json(hareketListe);
        }



        [HttpPost]
        [Nitelik.Log]
        public IHttpActionResult HareketPost(string Bilet, string degisken2)
        {
            
            var form = Request.Content.ReadAsStringAsync();
            var YerAdi = Request.Headers.GetValues("makale").ToList()[0];


            var hareketListe = db.makale.Where(s => s.baslik == YerAdi)
                                 .Select(p => new { p.Mno, p.baslik,p.yazildigitarih, p.metin});

            return Json(hareketListe);
        }

    }
}
