using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace test.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class LoginController : ControllerBase
    {
        
        public LoginController()
        {

        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="username">账号</param>
        /// 
        /// <returns></returns>
        [HttpGet]
        public ActionResult user(string username)
        {
            
            return Ok(a);
        }
        //[HttpPost]
        //public ActionResult user(Admin admin)
        //{ 
        
        //}
    }
}