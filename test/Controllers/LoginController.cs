using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;

namespace test.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class LoginController : ControllerBase
    {
        private readonly IAdminRepository _adminRepository;
        private readonly IUnitOfWork _unitOfWork;
        public LoginController(IAdminRepository adminRepository,IUnitOfWork unitOfWork)
        {
            _adminRepository = adminRepository;
            _unitOfWork = unitOfWork;
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
            var a = _adminRepository.user(username);
            return Ok(a);
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="admin">用户数组</param>
        /// <returns></returns>
        /// <response code="1">查询成功</response>
        [HttpPost]
        public async Task<ActionResult> user(Admin admin)
        {
            _adminRepository.Insert(admin);
          await  _unitOfWork.SaveAsync();
            return Ok();

        }
    }
}