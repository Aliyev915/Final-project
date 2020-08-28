using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.DAL;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _db;
        public BlogController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Blog> model = _db.Blogs;
            return View(model);
        }

        public IActionResult Detail(int? Id)
        {
            ViewBag.Blogs = _db.Blogs.OrderByDescending(b=>b.Id).Take(3);
            if (Id == null) return NotFound();
            Blog blog = _db.Blogs.FirstOrDefault(b=>b.Id==Id);
            if (blog == null) NotFound();
            return View(blog);
        }
    }
}