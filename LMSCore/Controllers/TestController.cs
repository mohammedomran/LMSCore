using LMSCore.Filters;
using LMSCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMSCore.Controllers
{
    [Route("api/[controller]")]
    [CustomModelValidate]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpPost]
        public ActionResult<Course> StoreCourse([FromBody] Course course)
        {
            if (!ModelState.IsValid)
                return BadRequest("not valid model");

            return Ok("valid model");
        }
    }
}
