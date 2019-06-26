using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogSitesi.Models;
using PagedList;
using PagedList.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;

namespace BlogSitesi.Controllers
{
    public class HomeController : Controller
    {

        BlogSitesiDB db = new BlogSitesiDB();
        // GET: Home
        public ActionResult Index(int Page = 1)
        {
            var makale = db.Makales.OrderByDescending(m => m.MakaleId).ToPagedList(Page, 5);
            return View(makale);
        }
        public ActionResult Anasayfa()
        {
            return View();

        }

        public ActionResult Hakkimda()
        {
            return View();

        }

        public ActionResult Iletisim ()
        {
            return View();

        }


        public ActionResult KategoriPartial()
        {
            return View(db.Kategoris.ToList());

        }

        public ActionResult UyeCek()
        {
            List<Models.Uye> list = new List<Uye>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:51034");
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/uyecek").Result;
            if (response.IsSuccessStatusCode)
            {
                list = response.Content.ReadAsAsync<List<Uye>>().Result;

            }
            return View(list);
        }

    }
}