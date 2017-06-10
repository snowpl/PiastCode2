using Crud.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crud.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOutgoingQueryServices _outgoingQueryServices;
        public HomeController(IOutgoingQueryServices outgoingQueryServices)
        {
            _outgoingQueryServices = outgoingQueryServices;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(double lat, double lon, double distance)
        {
            var outgoings = _outgoingQueryServices.GetOutgoingsFromDistance(lat, lon, distance);
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}