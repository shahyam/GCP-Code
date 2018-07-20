using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    [Route("api/myapi")]
    public class MyApiController : Controller
    {
         [HttpGet]
         public string Get(){
             return "Hi Welcome to My First Web Api hosted on GCP";
         }
    }
}