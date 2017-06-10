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

namespace Crud.Controllers
{
    public class OutgoingController : BaseController
    {
        private readonly IOutgoingQueryServices _outgoingQueryServices;
        private readonly IOutgoingCommandRepository _outGoingCommandRepository;

        public OutgoingController(
            IOutgoingQueryServices outgoingQueryServices, IOutgoingCommandRepository outGoingCommandRepository)
        {
            _outgoingQueryServices = outgoingQueryServices;
            _outGoingCommandRepository = outGoingCommandRepository;
        }

        [HttpGet]
        public JsonResult GetOutgoings()
        {
            var result = _outgoingQueryServices.GetAllOutgoings();
            var jsonresult = JsonConvert.SerializeObject(result);
            return Json(jsonresult, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddOutgoings(string outgoing)
        {
            try
            {
                var newOutgoing = System.Web.Helpers.Json.Decode<OutgoingDTO>(outgoing);
                //ODWOLUJEMY SIE DO SERVICES NIE DO REPO
                //_outGoingCommandRepository.AddEditOutgoing(OutgoingDTOMapping.Map(newOutgoing));
                var result=new HttpStatusCodeResult(200);
                return result;

            }
            catch (Exception)
            {
                throw new HttpRequestException();
            }
            

        }
    }
}