using Crud.IServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crud.Controllers
{
    public class OutgoingController : BaseController
    {
        private readonly IOutgoingQueryServices _outgoingQueryServices;

        public OutgoingController(
            IOutgoingQueryServices outgoingQueryServices)
        {
            _outgoingQueryServices = outgoingQueryServices;
        }

        [HttpGet]
        public JsonResult GetOutgoings()
        {
            var result = _outgoingQueryServices.GetAllOutgoings();
            var jsonresult = JsonConvert.SerializeObject(result);
            return Json(jsonresult, JsonRequestBehavior.AllowGet);
        }
    }
}