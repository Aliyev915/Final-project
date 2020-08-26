using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Service> Services { get; set; }

        #region SeedData
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData
                (
                    new Category { Id = 1, Name = "Accounting/Finance", Icon = "<i class='fas fa-hand-holding-usd'></i>" },
                    new Category { Id = 2, Name = "Education Training", Icon = "<i class='fas fa-graduation-cap'></i>" },
                    new Category { Id = 3, Name = "Hotel", Icon = "<i class='fas fa-hotel'></i>" }
                );

            modelBuilder.Entity<Company>().HasData
                (
                    new Company { Id = 1, Logo = "logo-1.png", Brand="brand-1.png" },
                    new Company { Id = 2, Logo = "logo-2.png", Brand = "brand-2.png" }
                );

            modelBuilder.Entity<Location>().HasData
                (
                    new Location { Id = 1, Name = "Baku" },
                    new Location { Id = 2, Name = "Gandja" },
                    new Location { Id = 3, Name = "Sumgayit" }
                );

            modelBuilder.Entity<Job>().HasData
                (
                    new Job { Id = 1, Name = "Green Development Marketer", LocationId = 1, CategoryId = 3, CompanyId = 1 },
                    new Job { Id = 2, Name = "Restaurant General Manager", LocationId = 2, CategoryId = 1, CompanyId = 2 }
                );

            modelBuilder.Entity<Statistic>().HasData
                (
                    new Statistic { Id = 1, Icon= "<i class='far fa-user'></i>",Title="Members" },
                    new Statistic { Id = 2, Icon = "<i class='fas fa-briefcase'></i>", Title = "Jobs" },
                    new Statistic { Id = 3, Icon = "<i class='far fa-file-alt'></i>", Title = "Resumes" },
                    new Statistic { Id = 4, Icon = "<i class='fas fa-industry'></i>", Title = "Companies" }
                ) ;

            modelBuilder.Entity<Blog>().HasData
                (
                    new Blog 
                    { 
                        Id=1,
                        Title="Back To Work Vacantion",
                        Image="blog-1.jpg",
                        Description= "Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                        " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer " +
                        "took a galley of type and scrambled it to make a type specimen book. It has survived not only five",
                        Time =DateTime.Today
                    },
                    new Blog 
                    { 
                        Id = 2, 
                        Title = "Job Motivational Quote",
                        Image = "blog-2.jpg",
                        Description= "lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the " +
                        "industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled " +
                        "it to make a type specimen book. It has survived not only five centuries.But also the leap into electronic " +
                        "typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset " +
                        "sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus " +
                        "PageMaker including versions of Lorem Ipsum.But also the leap into electronic typesetting, remaining " +
                        "essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing " +
                        "Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including " +
                        "versions of Lorem Ipsum. But also the leap into electronic typesetting, remaining essentially unchanged. " +
                        "It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more " +
                        "recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.more recently " +
                        "with desktop publishing",
                        Time = DateTime.Today 
                    }

                );

            modelBuilder.Entity<Slider>().HasData
                (
                    new Slider { Id=1, Image="img-1.jpg"},
                    new Slider { Id =2, Image = "img-2.jpg" },
                    new Slider { Id =3, Image = "img-3.jpg" }
                );

            modelBuilder.Entity<Service>().HasData
                (
                    new Service 
                    { 
                        Id=1,
                        Title= "Advertise A Job",
                        Description= "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod",
                        Icon= "<i class='fas fa-briefcase'></i>"
                    },
                    new Service 
                    {
                        Id = 2,
                        Title = "CV Search",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod",
                        Icon = "<i class='fas fa-search'></i>"
                    },
                    new Service
                    {
                        Id = 3,
                        Title = "Recruiter Profiles",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod",
                        Icon = "<i class='far fa-user'></i>"
                    }
                );
        }

        #endregion
    }
}
