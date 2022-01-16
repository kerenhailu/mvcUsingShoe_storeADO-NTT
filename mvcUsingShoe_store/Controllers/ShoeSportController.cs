using mvcUsingShoe_store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcUsingShoe_store.Controllers
{
    public class ShoeSportController : Controller
    {
        ShoesStore SportShoes = new ShoesStore(0, "nike", "aa", 35, 40);
        ShoesStore[] shoesStores = new ShoesStore[]
        {
            new ShoesStore(0, "nike","aa",35,40),
            new ShoesStore(1, "adidas","rr",39,47),
            new ShoesStore(2, "p&b","bb",42,22)
    };
        // GET: ShoeSport
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowNameShoes()
        {
            //ViewBag.Name = "mazda";
            return View(shoesStores[0]);
        }
        public ActionResult ShowOneShoes()
        {
            return View(shoesStores[0]);
        }
        public ActionResult ShowShoes()
        {
            return View(shoesStores);
        }
    }
}