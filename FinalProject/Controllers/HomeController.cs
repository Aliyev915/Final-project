using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FinalProject.DAL;
using FinalProject.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            HomeVM model = new HomeVM
            {
                Categories=_db.Categories.Include(c=>c.Jobs),
                Jobs=_db.Jobs.Include(j=>j.Category).Include(j=>j.Company).Include(j=>j.Location),
                Companies=_db.Companies,
                Locations=_db.Locations,
                Statistics=_db.Statistics,
                Blogs=_db.Blogs
            };
            return View(model);
        }
    }
}
