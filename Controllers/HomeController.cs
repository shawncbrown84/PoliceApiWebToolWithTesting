using Newtonsoft.Json;
using PoliceApiWebToolWithTesting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace PoliceApiWebToolWithTesting.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Some default values
            ViewData["Latitude"] = 51.44237;
            ViewData["Longitude"] = -2.49810;
            ViewData["Date"] = "2021-01";
            return View();
        }

        [HttpPost]
        public ActionResult Index(double Latitude, double Longitude, string Date)
        {
            try
            {
                ViewData["Latitude"] = Latitude;
                ViewData["Longitude"] = Longitude;
                ViewData["Date"] = Date;
                return View("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Summary(double Latitude, double Longitude, string Date)
        {
            string URL = "https://data.police.uk/";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);
            HttpResponseMessage response = client.GetAsync("api/crimes-street/all-crime?lat=" + Latitude + "&lng=" + Longitude + "&date=" + Date).Result;

            string sCrimes = response.Content.ReadAsStringAsync().Result;

            List<Crime> crimes = JsonConvert.DeserializeObject<List<Crime>>(sCrimes);

            var crimesSummary = (from c in crimes
                                 group c.category by c.category into g
                                 select new CrimeSummary { category = g.Key, count = g.Count() })
                                .ToList();

            crimesSummary.Add(new CrimeSummary { category = "All", count = crimes.Count() });

            return PartialView(crimesSummary);
        }



        public ActionResult AllData(double Latitude, double Longitude, string Date)
        {
            string URL = "https://data.police.uk/";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);
            HttpResponseMessage response = client.GetAsync("api/crimes-street/all-crime?lat=" + Latitude + "&lng=" + Longitude + "&date=" + Date).Result;

            string sCrimes = response.Content.ReadAsStringAsync().Result;

            List<Crime> crimes = JsonConvert.DeserializeObject<List<Crime>>(sCrimes);

            return PartialView(crimes);
        }




        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}