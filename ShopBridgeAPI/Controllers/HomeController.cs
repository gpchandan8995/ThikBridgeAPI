using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ShopBridgeAPI.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        InventoryEntities db =new InventoryEntities();
        public ActionResult Index()
        {
            var dataList = db.Items.ToList();
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
            ViewBag.Message = " Data Added Sucessfully ";
            return View("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = db.Items.Where(x => x.Id==id).FirstOrDefault() ;
            return View(data);    
        }

        [HttpPost]
        public ActionResult Edit(Item item)
        {
            var data = db.Items.Where(x => x.Id == item.Id).FirstOrDefault();
            if (data != null)
            {
                data.Iname = item.Iname;
                data.Idescription= item.Idescription;
                data.Iprice = item.Iprice;
                data.IaddDate = item.IaddDate;
                data.IexpDate= item.IexpDate;
                data.Iavailable = item.Iavailable;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        public ActionResult Delete(int id)
        {
            var data = db.Items.Where(x => x.Id == id).FirstOrDefault();
            try
            {
                db.Items.Remove(data);
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException();
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}