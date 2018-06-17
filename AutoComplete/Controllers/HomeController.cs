using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoComplete.Models;

namespace AutoComplete.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getAllCountries()
        {
            using (CountryModel db = new CountryModel()) 
            {
                var countryList = db.Countries.OrderBy(a => a.CountryName).ToList();
                return new JsonResult
                {
                    Data = countryList,
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet
                };
            }
            
        }
    }
}