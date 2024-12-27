using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2WooxTravel_New.Context;
using Project2WooxTravel_New.Entities;

namespace Project2WooxTravel_New.Areas.Admin.Controllers
{ 
    [Authorize]
    public class ProfileController : Controller
    {
        TravelContext context=new TravelContext();

        // GET: Admin/Profile
        [HttpGet]
        public ActionResult Index()
        {
            var a = Session["x"];
            var values=context.Admins.Where(x=>x.UserName==a).FirstOrDefault();
            return View(values);
        }

        [HttpPost]
        public ActionResult Index(Project2WooxTravel_New.Entities.Admin admin)
        {
			var a = Session["x"];
			var values = context.Admins.Where(x => x.UserName == a).FirstOrDefault();
            values.Name = admin.Name;   
            values.Surname = admin.Surname;
            values.Email = admin.Email;
            values.UserName = admin.UserName;
            values.Password = admin.Password;
            context.SaveChanges();
			return RedirectToAction("Index","Profile","Admin");
        }
    }
}