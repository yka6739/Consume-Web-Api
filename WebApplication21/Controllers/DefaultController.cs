using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication21.Controllers
{
    public class DefaultController : ApiController
    {
        public IHttpActionResult getempdetails()
        {


            WebAPI_CRUDEntities sd = new WebAPI_CRUDEntities();
            var results = sd.Users.ToList();
            return Ok(results);
        }
        
    }
}
