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
        public DbSet<Bio> Bio { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Candidate_Experience> Experiences { get; set; }
        public DbSet<Candidate_Education> Educations { get; set; }
        public DbSet<Candidate_Skill> Skills { get; set; }
        public DbSet<Demand> Demands { get; set; }

        #region SeedData
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Bio
            modelBuilder.Entity<Bio>().HasData
                (
                    new Bio
                    {
                        Id = 1,
                        Logo = "logo.png",
                        BlackLogo = "black-logo.png",
                        Phone = "+55 417 634 7071",
                        Address = "20/F Green Road, Dhaka",
                        Email = "info@themevessel.com",
                        Web = "info@themevessel.com"
                    }
                );
            #endregion

            #region LinkSeed
            modelBuilder.Entity<Link>().HasData
                (
                    new Link { Id = 1, Name = "Dashboard", Icon= "<i class='fas fa-tachometer-alt'></i>",Controller="Dashboard" },
                    new Link { Id = 2, Name = "Post a New Job", Icon = "<i class='fas fa-plus'></i>",Controller="Post" },
                    new Link { Id = 3, Name = "Manage Candidate", Icon = "<i class='fas fa-user-check'></i>",Controller="Candidate" },
                    new Link { Id = 4, Name = "Manage Jobs", Icon = "<i class='fas fa-briefcase'></i>",Controller="Job" },
                    new Link { Id = 5, Name = "Manage Blogs", Icon = "<i class='fas fa-blog'></i>",Controller="Blog" },
                    new Link { Id = 6, Name = "Message", Icon = "<i class='far fa-envelope'></i>",Controller="Message" },
                    new Link { Id = 7, Name = "Edit Profile", Icon = "<i class='fas fa-user-edit'></i>",Controller="Profile/Edit" },
                    new Link { Id = 8, Name = "Logout", Icon = "<i class='fas fa-sign-out-alt'></i>",Controller="Account/Logout" }
                );
            #endregion

            #region CategorySeed
            modelBuilder.Entity<Category>().HasData
                (
                    new Category { Id = 1, Name = "Accounting/Finance", Icon = "<i class='fas fa-hand-holding-usd'></i>" },
                    new Category { Id = 2, Name = "Education Training", Icon = "<i class='fas fa-graduation-cap'></i>" },
                    new Category { Id = 3, Name = "Hotel", Icon = "<i class='fas fa-hotel'></i>" }
                );
            #endregion

            #region CompanySeed
            modelBuilder.Entity<Company>().HasData
                (
                    new Company 
                    { 
                        Id = 1,
                        Logo = "logo-1.png",
                        Brand = "brand-1.png",
                        Name= "The Kings",
                        Adress= " 20/F Green Road, Dhaka",
                        About = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                        " Donec luctus tincidunt aliquam. Aliquam gravida massa at sem vulputate interdum."
                    },
                    new Company 
                    { 
                        Id = 2,
                        Logo = "logo-2.png",
                        Brand = "brand-2.png",
                        Name = "The Kings",
                        Adress= " 20/F Green Road, Dhaka",
                        About = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                        " Donec luctus tincidunt aliquam. Aliquam gravida massa at sem vulputate interdum."
                    }
                );
            #endregion

            #region LocationSeed
            modelBuilder.Entity<Location>().HasData
                (
                    new Location { Id = 1, Name = "Baku" },
                    new Location { Id = 2, Name = "Gandja" },
                    new Location { Id = 3, Name = "Sumgayit" }
                );
            #endregion

            #region JobSeed
            modelBuilder.Entity<Demand>().HasData
                (
                    new Demand 
                    { 
                        Id=1,
                        Education ="M.B.S / M.B.A under National University with CA course complete_ " +
                            "3 or more years of professional design experience_ "+
                            "Excellent communication skills, most notably a demonstrated ability to solicit and address creative and design feedback_ "+
                            "Masters of library science any Green University_ "+
                            "BA/BS degree in a technical field or equivalent practical experience"
                    }, 
                    new Demand
                    {
                        Id = 2,
                        Education ="Explore and design dynamic and compelling consumer experiences_"+
                            "Have sound knowledge of commercial activities_"+
                            "Build next-generation web applications with a focus on the client side_"+
                            "The applicants should have experience in the following areas"
                    }

                );

            modelBuilder.Entity<Job>().HasData
                (
                    new Job 
                    { 
                        Id = 1,
                        Name = "Green Development Marketer",
                        Salary=1000,
                        Experience="1-2",
                        Description= "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas in pulvinar neque. Nulla finibus lobortis pulvinar." +
                        " Donec a consectetur nulla. Nulla posuere sapien vitae lectus suscipit, et pulvinar nisi tincidunt. Aliquam erat volutpat." +
                        " Curabitur convallis fringilla diam sed aliquam. Sed tempor iaculis massa faucibus feugiat." +
                        " In fermentum facilisis massa, a consequat purus viverra a." +
                        " Aliquam pellentesque nibh et nibh feugiat gravida." +
                        " Maecenas ultricies, diam vitae semper placerat, velit risus accumsan nisl, eget tempor lacus est vel nunc." +
                        " Proin accumsan elit sed neque euismod fringilla. Curabitur lobortis nunc velit, et fermentum urna dapibus non." +
                        " Vivamus magna lorem, elementum id gravida ac, laoreet tristique augue." +
                        " Maecenas dictum lacus eu nunc porttitor, ut hendrerit arcu efficitur.",
                        LocationId = 1,
                        CategoryId = 3,
                        CompanyId = 1,
                        DemandId=1
                    },
                    new Job 
                    { 
                        Id = 2,
                        Name = "Restaurant General Manager",
                        Salary=1500,
                        Experience = "2-3",
                        LocationId = 2,
                        CategoryId = 1,
                        CompanyId = 2,
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas in pulvinar neque. Nulla finibus lobortis pulvinar." +
                        " Donec a consectetur nulla. Nulla posuere sapien vitae lectus suscipit, et pulvinar nisi tincidunt. Aliquam erat volutpat." +
                        " Curabitur convallis fringilla diam sed aliquam. Sed tempor iaculis massa faucibus feugiat." +
                        " In fermentum facilisis massa, a consequat purus viverra a." +
                        " Aliquam pellentesque nibh et nibh feugiat gravida." +
                        " Maecenas ultricies, diam vitae semper placerat, velit risus accumsan nisl, eget tempor lacus est vel nunc." +
                        " Proin accumsan elit sed neque euismod fringilla. Curabitur lobortis nunc velit, et fermentum urna dapibus non." +
                        " Vivamus magna lorem, elementum id gravida ac, laoreet tristique augue." +
                        " Maecenas dictum lacus eu nunc porttitor, ut hendrerit arcu efficitur.",
                        DemandId=2
                    }
                );
            #endregion

            #region StatisticSeed
            modelBuilder.Entity<Statistic>().HasData
                (
                    new Statistic { Id = 1, Icon = "<i class='far fa-user'></i>", Title = "Members" },
                    new Statistic { Id = 2, Icon = "<i class='fas fa-briefcase'></i>", Title = "Jobs" },
                    new Statistic { Id = 3, Icon = "<i class='far fa-file-alt'></i>", Title = "Resumes" },
                    new Statistic { Id = 4, Icon = "<i class='fas fa-industry'></i>", Title = "Companies" }
                );
            #endregion

            #region BlogSeed
            modelBuilder.Entity<Blog>().HasData
                (
                    new Blog
                    {
                        Id = 1,
                        Title = "Back To Work Vacantion",
                        Image = "blog-1.jpg",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                        " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer " +
                        "took a galley of type and scrambled it to make a type specimen book. It has survived not only five",
                        Time = DateTime.Today
                    },
                    new Blog
                    {
                        Id = 2,
                        Title = "Job Motivational Quote",
                        Image = "blog-2.jpg",
                        Description = "lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the " +
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
            #endregion

            #region SliderSeed
            modelBuilder.Entity<Slider>().HasData
                (
                    new Slider { Id = 1, Image = "img-1.jpg" },
                    new Slider { Id = 2, Image = "img-2.jpg" },
                    new Slider { Id = 3, Image = "img-3.jpg" }
                );
            #endregion

            #region ServiceSeed
            modelBuilder.Entity<Service>().HasData
                (
                    new Service
                    {
                        Id = 1,
                        Title = "Advertise A Job",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod",
                        Icon = "<i class='fas fa-briefcase'></i>"
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
            #endregion

            #region CandidateSeed
            modelBuilder.Entity<Candidate_Skill>().HasData
                (
                    new Candidate_Skill
                    {
                        Id = 1,
                        Community = 85,
                        Language = 75,
                        LeaderShip = 80,
                        Speciality = 80
                    },
                    new Candidate_Skill
                    {
                        Id = 2,
                        Community = 95,
                        Language = 85,
                        LeaderShip = 80,
                        Speciality = 90
                    },
                    new Candidate_Skill
                    {
                        Id = 3,
                        Community = 85,
                        Language = 90,
                        LeaderShip = 85,
                        Speciality = 95
                    }
                ) ;

            modelBuilder.Entity<Candidate_Experience>().HasData
                (
                    new Candidate_Experience 
                    { 
                        Id=1,
                        Speciality= "Web Designer",
                        Company="Themeforest",
                        ExperienceYear= "2015 - 2019",
                        CandidateId=1
                    },
                    new Candidate_Experience 
                    { 
                        Id =2,
                        Speciality="Graphic Designer",
                        Company = "Themeforest",
                        ExperienceYear = "2019 - 2020",
                        CandidateId=1
                    }
                );

            modelBuilder.Entity<Candidate_Education>().HasData
                (
                    new Candidate_Education
                    {
                        Id=1,
                        School= "Dhaka College",
                        Speciality="Themeforest",
                        EducationYear="2012-2016",
                        CandidateId=1
                    },
                    new Candidate_Education
                    {
                        Id = 2,
                        School = "University of south asia",
                        Speciality = "Themeforest",
                        EducationYear = "2016-2018",
                        CandidateId=1
                    }
                );

            modelBuilder.Entity<Candidate>().HasData
                (
                    new Candidate 
                    { 
                        Id=1,
                        Image="avatar-1.jpg",
                        Fullname="Martin Smith",
                        Profession="Content Writer",
                        LocationId=1,
                        About= "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                        " Maecenas in pulvinar neque. Nulla finibus lobortis pulvinar." +
                        " Donec a consectetur nulla. Nulla posuere sapien vitae lectus suscipit, et pulvinar nisi tincidunt." +
                        " Aliquam erat volutpat. Curabitur convallis fringilla diam sed aliquam." +
                        " Sed tempor iaculis massa faucibus feugiat.In fermentum facilisis massa, a consequat purus viverra a." +
                        " Aliquam pellentesque nibh et nibh feugiat gravida." +
                        " Maecenas ultricies, diam vitae semper placerat, velit risus accumsan nisl, eget tempor lacus est vel nunc." +
                        " Proin accumsan elit sed neque euismod fringilla." +
                        " Curabitur lobortis nunc velit, et fermentum urna dapibus non." +
                        " Vivamus magna lorem, elementum id gravida ac, laoreet tristique augue." +
                        " Maecenas dictum lacus eu nunc porttitor, ut hendrerit arcu efficitur.",
                        Candidate_SkillId=1
                    },
                    new Candidate 
                    { 
                        Id =2,
                        Image="avatar-2.jpg",
                        Fullname="Karen Paren",
                        Profession ="Reustaurant Manager",
                        LocationId=1,
                        About = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                        " Maecenas in pulvinar neque. Nulla finibus lobortis pulvinar." +
                        " Donec a consectetur nulla. Nulla posuere sapien vitae lectus suscipit, et pulvinar nisi tincidunt." +
                        " Aliquam erat volutpat. Curabitur convallis fringilla diam sed aliquam." +
                        " Sed tempor iaculis massa faucibus feugiat.In fermentum facilisis massa, a consequat purus viverra a." +
                        " Aliquam pellentesque nibh et nibh feugiat gravida." +
                        " Maecenas ultricies, diam vitae semper placerat, velit risus accumsan nisl, eget tempor lacus est vel nunc." +
                        " Proin accumsan elit sed neque euismod fringilla." +
                        " Curabitur lobortis nunc velit, et fermentum urna dapibus non." +
                        " Vivamus magna lorem, elementum id gravida ac, laoreet tristique augue." +
                        " Maecenas dictum lacus eu nunc porttitor, ut hendrerit arcu efficitur.",
                        Candidate_SkillId = 2
                    },
                    new Candidate 
                    { 
                        Id =3,
                        Image ="avatar-3.jpg",
                        Fullname ="Phil Jones",
                        Profession = "Bookkeeper",
                        LocationId = 2,
                        About = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                        " Maecenas in pulvinar neque. Nulla finibus lobortis pulvinar." +
                        " Donec a consectetur nulla. Nulla posuere sapien vitae lectus suscipit, et pulvinar nisi tincidunt." +
                        " Aliquam erat volutpat. Curabitur convallis fringilla diam sed aliquam." +
                        " Sed tempor iaculis massa faucibus feugiat.In fermentum facilisis massa, a consequat purus viverra a." +
                        " Aliquam pellentesque nibh et nibh feugiat gravida." +
                        " Maecenas ultricies, diam vitae semper placerat, velit risus accumsan nisl, eget tempor lacus est vel nunc." +
                        " Proin accumsan elit sed neque euismod fringilla." +
                        " Curabitur lobortis nunc velit, et fermentum urna dapibus non." +
                        " Vivamus magna lorem, elementum id gravida ac, laoreet tristique augue." +
                        " Maecenas dictum lacus eu nunc porttitor, ut hendrerit arcu efficitur.",
                        Candidate_SkillId = 3
                    }
                );
            #endregion
        }

        #endregion
    }
}
