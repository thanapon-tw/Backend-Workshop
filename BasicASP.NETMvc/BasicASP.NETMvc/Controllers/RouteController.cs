﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace BasicASP.NETMvc.Controllers
{
    [AllowAnonymous]
    // Please change "api" to made this controller root path is "api/route"
    [RoutePrefix("api")]
    public class RouteController : ApiController
    {
        // Get
        // Change "xxx" and requet "/api/route/index" by Get
        [Route("xxx")]
        public string Get()
        {
            return "hello world";
        }

        [Route("index2")]
        public string Post()
        {
            return "hello world";
        }
    }
}