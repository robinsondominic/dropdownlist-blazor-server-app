using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorServeApp.Data;
using BlazorServeApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BlazorServeApp.Services
{

    public class GroupsListService
    {
        protected readonly ApplicationDbContext _dbcontext;

        public GroupsListService(ApplicationDbContext _db) 
        {
            _dbcontext = _db;
        }

        public List<GroupsListClass> groupsobj()
        {
            return _dbcontext.Groups.ToList();
        }

        public List<UserListClass> usersobj()
        {
            return _dbcontext.User.ToList();
        }
    }
}
