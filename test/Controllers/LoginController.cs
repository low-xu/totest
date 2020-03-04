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
        /// <param name="a">账号</param>
        /// <param name="b">密码</param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Login(string a,string b)
        {
            string c = a + b;
            return Ok(c);
        }
    }
}