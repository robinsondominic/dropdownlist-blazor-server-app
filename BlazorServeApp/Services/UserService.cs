using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorServeApp.Data;
using BlazorServeApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BlazorServeApp.Services
{

    public class UserService
    {
        protected readonly ApplicationDbContext _dbcontext;

        public UserService(ApplicationDbContext _db) 
        {
            _dbcontext = _db;
        }

        public List<UserClass> userobj()
        {
            return _dbcontext.User.ToList();
        }
    }
}
