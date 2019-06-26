using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcapicekme.Models;
using System.Net.Http;
using System.Net.Http.Headers;


namespace mvcapicekme.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<makaleapi> list = new List<makaleapi>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:6077");
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/makale").Result;
            if (response.IsSuccessStatusCode)
            {
                list = response.Content.ReadAsAsync<List<makaleapi>>().Result;

            }
            return View(list);
        }


    }
}