using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorServeApp.Data;
using BlazorServeApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BlazorServeApp.Services
{

    public class GroupsService
    {
        protected readonly ApplicationDbContext _dbcontext;

        public GroupsService(ApplicationDbContext _db) 
        {
            _dbcontext = _db;
        }

        public List<GroupsClass> groupsobj()
        {
            return _dbcontext.Groups.ToList();
        }

        public List<UserClass> usersobj()
        {
            return _dbcontext.User.ToList();
        }
    }
}
