using ICMDataManager.Library.DataAccess;
using ICMDataManager.Library.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace ICMDataMagager.Controllers
{
    [Authorize]
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
        //no Id in the method , it has to come from the logged in user

        [HttpGet]
        public UserModel GetById()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();
            UserData data = new UserData();


            //Default here might be a problem
            return data.GetUserById(userId).FirstOrDefault();
        }
    }
}