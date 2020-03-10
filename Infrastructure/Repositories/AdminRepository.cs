using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
  public  class AdminRepository:IAdminRepository
    {
        private readonly testContext _testContext;
        public AdminRepository(testContext testContext)
        {
            _testContext = testContext;
        }
        public void Insert(Admin admin)
        {
            _testContext.Add(admin);
        }

        

        public async ValueTask<IEnumerable<Admin>> user(string username)
        {
            return await _testContext.Admin.Where(a=>a.Username==username).ToListAsync();
        }
        public async Task<Admin> user(int id)
        {
            return await _testContext.Admin.FindAsync(id);
        }
        public  bool Del(int id)
        {
            var ad = _testContext.Admin.Find(id);
            if (ad==null)
            {
                return  false;
            }
            else
            {
                _testContext.Admin.Remove(ad);
                return true;
            }
           


        }

        private bool NoContent()
        {
            throw new NotImplementedException();
        }

        private bool NotFound()
        {
            throw new NotImplementedException();
        }
    }
}
