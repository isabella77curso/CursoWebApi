using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Aula01_Alo_GitHub
{
    public class Aula01_AloController : ApiController
    {
        // GET api/<controller>
        public string Get()
        {
            return "[THEOS CURSO WebAPI - Aula 01]: Alo, eu sou um método !!";
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}