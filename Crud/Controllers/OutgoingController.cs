using Crud.IServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Crud.DTO;
using IData.Interfaces.Command;
using Crud.IServices.Command;
using Crud.Data.Mappings;

namespace Crud.Controllers
{
    public class OutgoingController : BaseController
    {
        private readonly IOutgoingQueryServices _outgoingQueryServices;
        private readonly IOutgoingCommandService _outgoingCommandServices;

        public OutgoingController(
            IOutgoingQueryServices outgoingQueryServices,
            IOutgoingCommandService outgoingCommandServices)
        {
            _outgoingQueryServices = outgoingQueryServices;
            _outgoingCommandServices = outgoingCommandServices;
        }

        [HttpGet]
        public JsonResult GetOutgoings()
        {
            var result = _outgoingQueryServices.GetAllOutgoings();
            var jsonresult = JsonConvert.SerializeObject(result);
            return Json(jsonresult, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetOutgoing(int id)
        {
            var result = _outgoingQueryServices.GetOutgoingById(id);
            var jsonresult = JsonConvert.SerializeObject(result);
            return Json(jsonresult, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        //TO NIE ZADZIALA
        public ActionResult AddOutgoings(string outgoing)
        {
            try
            {
                var newOutgoing = System.Web.Helpers.Json.Decode<OutgoingDTO>(outgoing);
                
                _outgoingCommandServices.AddEditOutgoing(newOutgoing);
                var result =new HttpStatusCodeResult(200);
                return result;

            }
            catch (Exception)
            {
                throw new HttpRequestException();
            }
            

        }

        public ActionResult JoinOutgoing(int outgoingId)
        {
            var didJoin = _outgoingCommandServices.JoinOutgoing(outgoingId);
            return null;
        }
    }
}