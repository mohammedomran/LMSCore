using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace LMSCore.Filters
{
    public class CustomModelValidate : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                context.Result = new BadRequestObjectResult(new
                {
                    status = false,
                    code = HttpStatusCode.BadRequest,
                    message = context.ModelState.Values.SelectMany(x => x.Errors)
            });
            }
        }
    }
}
