using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;


namespace ShopBridgeAPI.Controllers
{
    public class LoginController : Controller
    {
        InventoryEntities db=new InventoryEntities();
        public ActionResult Signin()
        {
            return View("Signin");
        }

        public ActionResult afterSignin(Iuser user1)
        {
            List<Iuser> users = db.Iusers.ToList(); 
            foreach(Iuser user in users)
            {
                if(user.Uemail==user1.Uemail && user.Upass == user1.Upass)
                {
                    FormsAuthentication.SetAuthCookie(user1.Uemail, false);
                    return Redirect("/Home/Index");

                }
              
            }
            ViewBag.Title = " invalid username or password";
            return View("Signin");

        }
    }
}