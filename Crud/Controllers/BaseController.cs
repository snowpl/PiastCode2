using System.Collections.Generic;
using System.Web.Mvc;

namespace Crud.Controllers
{
    public class BaseController : Controller
    {
        protected List<string> GetErrors()
        {
            var errorList = new List<string>();
            foreach(var item in ModelState)
            {
                if(item.Value.Errors.Count > 0)
                {
                    foreach(var error in item.Value.Errors)
                    {
                        errorList.Add(error.ErrorMessage);
                    }
                }
            }

            return errorList;
        }

        protected virtual ActionResult SendErrorsToClientAsJson()
        {
            var errorList = GetErrors();
            return Json(new
            {
                HasErrors = true,
                Errors = errorList
            });
        }

    }

}