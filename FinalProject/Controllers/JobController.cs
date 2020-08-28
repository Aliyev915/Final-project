using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.DAL;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Controllers
{
    public class JobController : Controller
    {
        private readonly AppDbContext _db;
        public JobController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Job> model = _db.Jobs.Include(j=>j.Category).Include(j=>j.Company).Include(j=>j.Location);
            return View(model);
        }

        public async Task<IActionResult> Detail(int? Id)
        {
            if (Id == null) return NotFound();
            Job job = await _db.Jobs.Include(j => j.Company).Include(j=>j.Demand).Include(j=>j.Category).
                Include(j => j.Location).FirstOrDefaultAsync(j=>j.Id==Id);
            if (job == null) return NotFound();
            ViewBag.Demands = job.Demand.Education.Split('_');
            ViewBag.Jobs = _db.Jobs.Include(j => j.Location).Include(j => j.Company).Include(j=>j.Category).
                    Where(j=>j.CategoryId==job.CategoryId);
            return View(job);
        }
    }
}