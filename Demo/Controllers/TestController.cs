using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Controllers
{
    public class TestController : ControllerBase
    {
        //[Route("[Action]")]
        public object Hello()
        {
            return Ok(new { Status = true, Data = "Hello", Msg = string.Empty });
        }

        public object Hello2()
        {
            return Ok(new { Status = true, Data = "Hello", Msg = string.Empty });
        }
    }
}
