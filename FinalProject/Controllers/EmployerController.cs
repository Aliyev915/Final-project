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
    public class EmployerController : Controller
    {
        private readonly AppDbContext _db;
        public EmployerController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Company> model = _db.Companies.Include(c => c.Jobs);
            return View(model);
        }

        public async Task<IActionResult> Detail(int? Id)
        {
            if (Id == null) return NotFound();
            Company company = await _db.Companies.Include(c => c.Jobs).FirstOrDefaultAsync(c => c.Id == Id);
            if (company == null) return NotFound();
            ViewBag.Jobs = _db.Jobs.Include(j => j.Location).Include(j => j.Category).Include(j => j.Company).
                            Where(j => j.CompanyId == company.Id);
            return View(company);
        }
    }
}