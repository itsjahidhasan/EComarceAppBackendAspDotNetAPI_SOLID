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
        [Route("api/Admin/GetAll")]
        [HttpGet]
        public List<AdminModel> GetAll()
        {
            return AdminService.GetAll();
        }


        // GET api/<controller>/5
        [Route("api/Admin/Get/{id}")]
        [HttpGet]
        public AdminModel Get(int id)
        {
            return AdminService.Get(id);
        }

        

        // POST api/<controller>
        [Route("api/Admin/Insert")]
        [HttpPost]
        public void Insert([FromBody] AdminModel admin)
        {
            AdminService.Insert(admin);
        }
        

        // PUT api/<controller>/5
        [Route("api/Admin/Update")]
        [HttpPut]
        public void Update([FromBody] AdminModel admin)
        {
            AdminService.Upadte(admin);
        }

        // DELETE api/<controller>/5
        [Route("api/Admin/Delete/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            AdminService.Delete(id);
        }


        [Route("api/Admin/Logout")]
        [HttpGet]
        public HttpResponseMessage Logout()
        {
            var token = Request.Headers.Authorization.ToString();
            if (token != null)
            {
                var rs = AdminService.Logout(token);
                if (rs)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Sucess fully logged out");
                }

            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, "Invalid token to logout");
        }

        [Route("api/Admin/Login")]
        [HttpPost]
        public HttpResponseMessage Login(AdminModel admin)
        {

            //call to service
            var token = AdminService.Authenticate(admin);
            if (token != null)
            {

                return Request.CreateResponse(HttpStatusCode.OK, token);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "User not found");
        }
    }
}