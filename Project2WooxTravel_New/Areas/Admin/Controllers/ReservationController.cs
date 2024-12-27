using Project2WooxTravel_New.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2WooxTravel_New.Areas.Admin.Controllers
{
    public class ReservationController : Controller
    {
		TravelContext context = new TravelContext();
		// GET: Admin/Reservation
		public ActionResult ReservationList()
        {
            var values=context.Reservations.ToList();
            return View(values);
        }
    }
}