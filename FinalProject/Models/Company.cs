﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Company
    {
        public int Id { get; set; }
        [Required,StringLength(100)]
        public string Name { get; set; }
        [Required, StringLength(1000)]
        public string About { get; set; }
        [Required, StringLength(500)]
        public string Logo { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required, StringLength(500)]
        public string Brand { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
