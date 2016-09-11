using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi0911.Controllers
{
    public class Person
    {
        public string name { get; set; }
        public string age { get; set; }
    }
    public class TestController : ApiController
    {
        [Route("simple1")]
        public IHttpActionResult GetSimple1(string name, string age)
        {
            return Ok(name + "-" + age);
        }

        [Route("simple2")]
        public IHttpActionResult PostSimple2(string name, [FromBody]string age)
        {
            return Ok(name + "-" + age);
        }

        [Route("simple3")]
        public IHttpActionResult PostSimple3(Person person)
        {
            return Ok(person.name + "-" + person.age);
        }
    }
}
