using Infrastructure.Interfaces;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
  public   class UnitOfWork: IUnitOfWork
    {
        private readonly testContext _testContext;
        public UnitOfWork(testContext testContext)
        {
            _testContext = testContext;
        }
        public async Task<bool> SaveAsync()
        {
            return await _testContext.SaveChangesAsync() > 0;
        }
    }
}
