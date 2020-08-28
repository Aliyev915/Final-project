using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;
using FinalProject.DAL;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Controllers
{
    public class CandidateController : Controller
    {
        private readonly AppDbContext _db;
        public CandidateController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Candidate> model = _db.Candidates.Include(c => c.Location);
            return View(model);
        }

        public async Task<IActionResult> Detail(int? Id)
        {
            if (Id == null) return NotFound();
            Candidate candidate = await _db.Candidates.Include(c => c.Candidate_Skill).Include(c => c.Candidate_Education)
                .Include(c => c.Candidate_Experience).Include(c=>c.Location).FirstOrDefaultAsync(c => c.Id == Id);
            if (candidate == null) return NotFound();
            return View(candidate);
        }
    }
}