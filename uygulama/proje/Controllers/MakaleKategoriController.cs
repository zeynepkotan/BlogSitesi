using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using proje.Models;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Net;




namespace proje.Controllers
{
    public class MakaleKategoriController : Controller
    {
        Makalee db = new Makalee();
        // GET: MakaleKategori
        public ActionResult Index()
        {
            var liste = db.kategori.ToList();

            return View("Index",liste);
        }

       

    }
}