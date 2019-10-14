﻿using InterBlock.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InterBlock.Api.Service.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            ExtendedRepository<TestClass> db = new ExtendedRepository<TestClass>(new Helpers.Configurations.IBConfiguration() { Connection = new Helpers.Configurations.Connections("Constr"), DbType = Helpers.Enums.DataBaseType.MSSql });

            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}