using LoginDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LoginServices.Controllers
{
    public class LoginController : ApiController
    {
        LoginDetailsEntities entities = new LoginDetailsEntities();

        [HttpGet]
        public HttpResponseMessage GetAllUser()
        {
            var list = entities.User.ToList();
            if (list != null)
                return Request.CreateResponse(HttpStatusCode.OK, list);
            else return Request.CreateResponse(HttpStatusCode.NotFound);
        }
        [HttpGet]
        public HttpResponseMessage GetUserById(int id)
        {
            var user = entities.User.FirstOrDefault(e => e.Id == id);
            if (user != null)
                return Request.CreateResponse(HttpStatusCode.OK, user);
            else return Request.CreateResponse(HttpStatusCode.NotFound);
        }
    }
}
