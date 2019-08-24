using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using webapi_mysql.Models;
using webapi_mysql.Context;
using System.Linq;

namespace webapi_mysql.Controllers
{       
    [Route("api/[controller]")]
    public class UsersController
    {

        [HttpGet("LoginUser")]
        // GET api/values
       public IEnumerable<User> LoginUser()
        {
            using (var db = new UserContext())
            {
                var users = db.Users.ToList();
                return users;
            }
        }
    }
}