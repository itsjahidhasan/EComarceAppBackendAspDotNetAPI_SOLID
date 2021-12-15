using BLL;
using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EHutbazar.Controllers
{
    public class AdminController : ApiController
    {
        // GET api/<controller>
       
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [Route("api/Admin/Get")]
        [HttpGet]
        public string Get(int id)
        {
            return "value";
        }

        [Route("api/Admin/GetAll")]
        [HttpGet]
        public List<AdminModel> GetAll()
        {
            return AdminService.GetAll();
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        [Route("api/Admin/Delete")]
        public void Delete(int id)
        {
        }
    }
}