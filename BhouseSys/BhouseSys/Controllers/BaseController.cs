using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BhouseSys.Repository;

namespace BhouseSys.Controllers
{
    public class BaseController : Controller
    {
        public BhouseDBEntities _db;
        public BaseRepository<User> _userRepo;

        public BaseController()
        {
            _userRepo = new BaseRepository<User>();
            _db = new BhouseDBEntities();
        }
    }
}