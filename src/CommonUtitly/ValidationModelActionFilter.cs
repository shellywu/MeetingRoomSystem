using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace CommonUtitly
{
    public class ValidationModelActionFilter : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var modelState = context.ModelState;

            if (!modelState.IsValid)
            {
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                Dictionary<string, string> errmsg = new Dictionary<string, string>();
                foreach (var key in modelState.Keys)
                {
                    if (modelState[key].Errors.Count > 0)
                    {
                        errmsg.Add(key, modelState[key].Errors[0].ErrorMessage);
                    }
                }
                context.Result = new JsonResult(new { modelInvalid = "", errinfo = errmsg });
            }
        }
    }
}
