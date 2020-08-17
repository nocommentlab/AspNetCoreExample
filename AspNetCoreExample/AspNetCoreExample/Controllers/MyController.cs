using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreExample.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
        #region Members
        private IContext _IContext;
        #endregion

        public MyController(IContext iContext)
        {
            _IContext = iContext;
        }

        [HttpGet]
        [Route("getvalue")]
        public IActionResult GetValue()
        {
            return Ok(string.Format("The value is: {0}", _IContext.GetValue()));
        }

        [HttpGet]
        [Route("increasevalue/{value}")]
        public IActionResult IncreaseValue(string value)
        {
            _IContext.IncreaseValue(Int32.Parse(value));
            
            return Ok("Value increased!");
        }

    }
}
