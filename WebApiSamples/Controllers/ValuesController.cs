using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exceptionless;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApiSamples.Controllers
{

    [ApiController]
    [Route("[controller]/[action]")]
    public class ValuesController : ControllerBase
    {
        // /Values/ThrowException
        [HttpGet]
        public string ThrowException()
        {
            int i = 0;
            try
            {
                i /= i;
            }
            catch (System.Exception ex)
            {
                ex.ToExceptionless().Submit();
            }

            return string.Empty;
        }
    }
}