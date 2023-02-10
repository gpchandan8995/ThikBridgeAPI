using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopBridgeAPI.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        InventoryEntities db =new InventoryEntities();
        public ActionResult Index()
        {
            var dataList= db.Items.ToList();    
            return View(dataList);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();  
        }
        [HttpPost]
        public ActionResult Create(Item item)
        {
            db.Items.Add(item);
            db.SaveChanges();
            ViewBag.Message = " Item added in Inventory";
            return View("index");
        }

    }
}