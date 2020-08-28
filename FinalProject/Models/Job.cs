﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Job
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime Deadline { get; set; }
        public int Salary { get; set; }
        public string Experience { get; set; }
        public string Description { get; set; }
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public int DemandId { get; set; }
        public virtual Demand Demand { get; set; }

    }
}
