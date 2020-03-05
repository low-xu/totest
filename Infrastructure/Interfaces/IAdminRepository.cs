using Infrastructure.Repositories;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
   public interface IAdminRepository
    {
       void Insert(Admin admin);
        Task<List<Admin>> user(string username);
        Task<Admin> user(int id);

    }
}
