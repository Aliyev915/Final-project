using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FinalProject.DAL;
using FinalProject.ViewModels;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;
using Microsoft.AspNetCore.Identity;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _usermanager;
        public HomeController(AppDbContext db,UserManager<AppUser> usermanager)
        {
            _db = db;
            _usermanager = usermanager;
        }
        public IActionResult Index()
        {
            ViewBag.UserCount = _usermanager.Users.Count();
            ViewBag.JobCount = _db.Jobs.Count();
            ViewBag.ResumeCount = _db.Candidates.Count();
            ViewBag.CompanyCount = _db.Companies.Count();
            HomeVM model = new HomeVM
            {
                Categories=_db.Categories.Include(c=>c.Jobs),
                Jobs=_db.Jobs.Include(j=>j.Category).Include(j=>j.Company).Include(j=>j.Location).Include(j=>j.Type).OrderByDescending(j=>j.Id).Take(3),
                Companies=_db.Companies,
                Locations=_db.Locations,
                Statistics=_db.Statistics,
                Blogs=_db.Blogs.OrderByDescending(b=>b.Id).Take(3)
            };
            return View(model);
        }
    }
}
