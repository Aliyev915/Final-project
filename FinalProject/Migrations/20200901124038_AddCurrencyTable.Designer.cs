﻿// <auto-generated />
using System;
using FinalProject.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinalProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200901124038_AddCurrencyTable")]
    partial class AddCurrencyTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinalProject.Models.Bio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("BlackLogo")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Email");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("Web");

                    b.HasKey("Id");

                    b.ToTable("Bio");

                    b.HasData(
                        new { Id = 1, Address = "20/F Green Road, Dhaka", BlackLogo = "black-logo.png", Email = "info@themevessel.com", Logo = "logo.png", Phone = "+55 417 634 7071", Web = "info@themevessel.com" }
                    );
                });

            modelBuilder.Entity("FinalProject.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Image")
                        .HasMaxLength(250);

                    b.Property<DateTime>("Time");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Blogs");

                    b.HasData(
                        new { Id = 1, Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five", Image = "blog-1.jpg", Time = new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), Title = "Back To Work Vacantion" },
                        new { Id = 2, Description = "lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries.But also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.But also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum. But also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.more recently with desktop publishing", Image = "blog-2.jpg", Time = new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), Title = "Job Motivational Quote" }
                    );
                });

            modelBuilder.Entity("FinalProject.Models.Candidate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About");

                    b.Property<int>("Candidate_SkillId");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("LocationId");

                    b.Property<string>("Profession")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("Candidate_SkillId");

                    b.HasIndex("LocationId");

                    b.ToTable("Candidates");

                    b.HasData(
                        new { Id = 1, About = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas in pulvinar neque. Nulla finibus lobortis pulvinar. Donec a consectetur nulla. Nulla posuere sapien vitae lectus suscipit, et pulvinar nisi tincidunt. Aliquam erat volutpat. Curabitur convallis fringilla diam sed aliquam. Sed tempor iaculis massa faucibus feugiat.In fermentum facilisis massa, a consequat purus viverra a. Aliquam pellentesque nibh et nibh feugiat gravida. Maecenas ultricies, diam vitae semper placerat, velit risus accumsan nisl, eget tempor lacus est vel nunc. Proin accumsan elit sed neque euismod fringilla. Curabitur lobortis nunc velit, et fermentum urna dapibus non. Vivamus magna lorem, elementum id gravida ac, laoreet tristique augue. Maecenas dictum lacus eu nunc porttitor, ut hendrerit arcu efficitur.", Candidate_SkillId = 1, Fullname = "Martin Smith", Image = "avatar-1.jpg", LocationId = 1, Profession = "Content Writer" },
                        new { Id = 2, About = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas in pulvinar neque. Nulla finibus lobortis pulvinar. Donec a consectetur nulla. Nulla posuere sapien vitae lectus suscipit, et pulvinar nisi tincidunt. Aliquam erat volutpat. Curabitur convallis fringilla diam sed aliquam. Sed tempor iaculis massa faucibus feugiat.In fermentum facilisis massa, a consequat purus viverra a. Aliquam pellentesque nibh et nibh feugiat gravida. Maecenas ultricies, diam vitae semper placerat, velit risus accumsan nisl, eget tempor lacus est vel nunc. Proin accumsan elit sed neque euismod fringilla. Curabitur lobortis nunc velit, et fermentum urna dapibus non. Vivamus magna lorem, elementum id gravida ac, laoreet tristique augue. Maecenas dictum lacus eu nunc porttitor, ut hendrerit arcu efficitur.", Candidate_SkillId = 2, Fullname = "Karen Paren", Image = "avatar-2.jpg", LocationId = 1, Profession = "Reustaurant Manager" },
                        new { Id = 3, About = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas in pulvinar neque. Nulla finibus lobortis pulvinar. Donec a consectetur nulla. Nulla posuere sapien vitae lectus suscipit, et pulvinar nisi tincidunt. Aliquam erat volutpat. Curabitur convallis fringilla diam sed aliquam. Sed tempor iaculis massa faucibus feugiat.In fermentum facilisis massa, a consequat purus viverra a. Aliquam pellentesque nibh et nibh feugiat gravida. Maecenas ultricies, diam vitae semper placerat, velit risus accumsan nisl, eget tempor lacus est vel nunc. Proin accumsan elit sed neque euismod fringilla. Curabitur lobortis nunc velit, et fermentum urna dapibus non. Vivamus magna lorem, elementum id gravida ac, laoreet tristique augue. Maecenas dictum lacus eu nunc porttitor, ut hendrerit arcu efficitur.", Candidate_SkillId = 3, Fullname = "Phil Jones", Image = "avatar-3.jpg", LocationId = 2, Profession = "Bookkeeper" }
                    );
                });

            modelBuilder.Entity("FinalProject.Models.Candidate_Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CandidateId");

                    b.Property<string>("EducationYear")
                        .IsRequired();

                    b.Property<string>("School")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Speciality")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.ToTable("Educations");

                    b.HasData(
                        new { Id = 1, CandidateId = 1, EducationYear = "2012-2016", School = "Dhaka College", Speciality = "Themeforest" },
                        new { Id = 2, CandidateId = 1, EducationYear = "2016-2018", School = "University of south asia", Speciality = "Themeforest" }
                    );
                });

            modelBuilder.Entity("FinalProject.Models.Candidate_Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CandidateId");

                    b.Property<string>("Company");

                    b.Property<string>("ExperienceYear");

                    b.Property<string>("Speciality");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.ToTable("Experiences");

                    b.HasData(
                        new { Id = 1, CandidateId = 1, Company = "Themeforest", ExperienceYear = "2015 - 2019", Speciality = "Web Designer" },
                        new { Id = 2, CandidateId = 1, Company = "Themeforest", ExperienceYear = "2019 - 2020", Speciality = "Graphic Designer" }
                    );
                });

            modelBuilder.Entity("FinalProject.Models.Candidate_Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Community");

                    b.Property<int>("Language");

                    b.Property<int>("LeaderShip");

                    b.Property<int>("Speciality");

                    b.HasKey("Id");

                    b.ToTable("Skills");

                    b.HasData(
                        new { Id = 1, Community = 85, Language = 75, LeaderShip = 80, Speciality = 80 },
                        new { Id = 2, Community = 95, Language = 85, LeaderShip = 80, Speciality = 90 },
                        new { Id = 3, Community = 85, Language = 90, LeaderShip = 85, Speciality = 95 }
                    );
                });

            modelBuilder.Entity("FinalProject.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new { Id = 1, Icon = "<i class='fas fa-hand-holding-usd'></i>", Name = "Accounting/Finance" },
                        new { Id = 2, Icon = "<i class='fas fa-graduation-cap'></i>", Name = "Education Training" },
                        new { Id = 3, Icon = "<i class='fas fa-hotel'></i>", Name = "Hotel" }
                    );
                });

            modelBuilder.Entity("FinalProject.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<string>("Adress")
                        .IsRequired();

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new { Id = 1, About = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec luctus tincidunt aliquam. Aliquam gravida massa at sem vulputate interdum.", Adress = " 20/F Green Road, Dhaka", Brand = "brand-1.png", Logo = "logo-1.png", Name = "The Kings" },
                        new { Id = 2, About = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec luctus tincidunt aliquam. Aliquam gravida massa at sem vulputate interdum.", Adress = " 20/F Green Road, Dhaka", Brand = "brand-2.png", Logo = "logo-2.png", Name = "The Kings" }
                    );
                });

            modelBuilder.Entity("FinalProject.Models.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Mark")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Currencies");

                    b.HasData(
                        new { Id = 1, Mark = "₼", Name = "AZN" },
                        new { Id = 2, Mark = "$", Name = "USD" },
                        new { Id = 3, Mark = "‎€", Name = "EURO" }
                    );
                });

            modelBuilder.Entity("FinalProject.Models.Demand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Education");

                    b.HasKey("Id");

                    b.ToTable("Demands");

                    b.HasData(
                        new { Id = 1, Education = "<li>M.B.S / M.B.A under National University with CA course complete</li> <li>3 or more years of professional design experience</li> <li>Excellent communication skills, most notably a demonstrated ability to solicit and address creative and design feedback</li> <li>Masters of library science any Green University</li> <li>BA/BS degree in a technical field or equivalent practical experience</li>" },
                        new { Id = 2, Education = "<li>Explore and design dynamic and compelling consumer experiences</li><li>Have sound knowledge of commercial activities</li><li>Build next-generation web applications with a focus on the client side</li><li>The applicants should have experience in the following areas</li>" }
                    );
                });

            modelBuilder.Entity("FinalProject.Models.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<int>("CompanyId");

                    b.Property<int>("CurrencyId");

                    b.Property<DateTime>("Deadline");

                    b.Property<int>("DemandId");

                    b.Property<string>("Description");

                    b.Property<string>("Experience");

                    b.Property<int>("LocationId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Salary");

                    b.Property<int>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("DemandId");

                    b.HasIndex("LocationId");

                    b.HasIndex("TypeId");

                    b.ToTable("Jobs");

                    b.HasData(
                        new { Id = 1, CategoryId = 3, CompanyId = 1, CurrencyId = 1, Deadline = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), DemandId = 1, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas in pulvinar neque. Nulla finibus lobortis pulvinar. Donec a consectetur nulla. Nulla posuere sapien vitae lectus suscipit, et pulvinar nisi tincidunt. Aliquam erat volutpat. Curabitur convallis fringilla diam sed aliquam. Sed tempor iaculis massa faucibus feugiat. In fermentum facilisis massa, a consequat purus viverra a. Aliquam pellentesque nibh et nibh feugiat gravida. Maecenas ultricies, diam vitae semper placerat, velit risus accumsan nisl, eget tempor lacus est vel nunc. Proin accumsan elit sed neque euismod fringilla. Curabitur lobortis nunc velit, et fermentum urna dapibus non. Vivamus magna lorem, elementum id gravida ac, laoreet tristique augue. Maecenas dictum lacus eu nunc porttitor, ut hendrerit arcu efficitur.", Experience = "1-2", LocationId = 1, Name = "Green Development Marketer", Salary = 1000, TypeId = 1 },
                        new { Id = 2, CategoryId = 1, CompanyId = 2, CurrencyId = 1, Deadline = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), DemandId = 2, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas in pulvinar neque. Nulla finibus lobortis pulvinar. Donec a consectetur nulla. Nulla posuere sapien vitae lectus suscipit, et pulvinar nisi tincidunt. Aliquam erat volutpat. Curabitur convallis fringilla diam sed aliquam. Sed tempor iaculis massa faucibus feugiat. In fermentum facilisis massa, a consequat purus viverra a. Aliquam pellentesque nibh et nibh feugiat gravida. Maecenas ultricies, diam vitae semper placerat, velit risus accumsan nisl, eget tempor lacus est vel nunc. Proin accumsan elit sed neque euismod fringilla. Curabitur lobortis nunc velit, et fermentum urna dapibus non. Vivamus magna lorem, elementum id gravida ac, laoreet tristique augue. Maecenas dictum lacus eu nunc porttitor, ut hendrerit arcu efficitur.", Experience = "2-3", LocationId = 2, Name = "Restaurant General Manager", Salary = 1500, TypeId = 2 }
                    );
                });

            modelBuilder.Entity("FinalProject.Models.Link", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Controller");

                    b.Property<string>("Icon");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Links");

                    b.HasData(
                        new { Id = 1, Controller = "Dashboard/Index", Icon = "<i class='fas fa-tachometer-alt'></i>", Name = "Dashboard" },
                        new { Id = 2, Controller = "Post/Create", Icon = "<i class='fas fa-plus'></i>", Name = "Post a New Job" },
                        new { Id = 3, Controller = "Candidate/Index", Icon = "<i class='fas fa-user-check'></i>", Name = "Manage Candidate" },
                        new { Id = 4, Controller = "Job/Index", Icon = "<i class='fas fa-briefcase'></i>", Name = "Manage Jobs" },
                        new { Id = 5, Controller = "Blog/Index", Icon = "<i class='fas fa-blog'></i>", Name = "Manage Blogs" },
                        new { Id = 6, Controller = "Message/Index", Icon = "<i class='far fa-envelope'></i>", Name = "Message" },
                        new { Id = 7, Controller = "Profile/Edit", Icon = "<i class='fas fa-user-edit'></i>", Name = "Edit Profile" },
                        new { Id = 8, Controller = "Account/Logout", Icon = "<i class='fas fa-sign-out-alt'></i>", Name = "Logout" }
                    );
                });

            modelBuilder.Entity("FinalProject.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new { Id = 1, Name = "Baku" },
                        new { Id = 2, Name = "Gandja" },
                        new { Id = 3, Name = "Sumgayit" }
                    );
                });

            modelBuilder.Entity("FinalProject.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Icon")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("Services");

                    b.HasData(
                        new { Id = 1, Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod", Icon = "<i class='fas fa-briefcase'></i>", Title = "Advertise A Job" },
                        new { Id = 2, Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod", Icon = "<i class='fas fa-search'></i>", Title = "CV Search" },
                        new { Id = 3, Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod", Icon = "<i class='far fa-user'></i>", Title = "Recruiter Profiles" }
                    );
                });

            modelBuilder.Entity("FinalProject.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Sliders");

                    b.HasData(
                        new { Id = 1, Image = "img-1.jpg" },
                        new { Id = 2, Image = "img-2.jpg" },
                        new { Id = 3, Image = "img-3.jpg" }
                    );
                });

            modelBuilder.Entity("FinalProject.Models.Statistic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Icon");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Statistics");

                    b.HasData(
                        new { Id = 1, Icon = "<i class='far fa-user'></i>", Title = "Members" },
                        new { Id = 2, Icon = "<i class='fas fa-briefcase'></i>", Title = "Jobs" },
                        new { Id = 3, Icon = "<i class='far fa-file-alt'></i>", Title = "Resumes" },
                        new { Id = 4, Icon = "<i class='fas fa-industry'></i>", Title = "Companies" }
                    );
                });

            modelBuilder.Entity("FinalProject.Models.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Types");

                    b.HasData(
                        new { Id = 1, Name = "Full Time" },
                        new { Id = 2, Name = "Part Time" },
                        new { Id = 3, Name = "Temprorary" },
                        new { Id = 4, Name = "Freelance" }
                    );
                });

            modelBuilder.Entity("FinalProject.Models.Candidate", b =>
                {
                    b.HasOne("FinalProject.Models.Candidate_Skill", "Candidate_Skill")
                        .WithMany()
                        .HasForeignKey("Candidate_SkillId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FinalProject.Models.Location", "Location")
                        .WithMany("Candidates")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FinalProject.Models.Candidate_Education", b =>
                {
                    b.HasOne("FinalProject.Models.Candidate", "Candidate")
                        .WithMany("Candidate_Education")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FinalProject.Models.Candidate_Experience", b =>
                {
                    b.HasOne("FinalProject.Models.Candidate", "Candidate")
                        .WithMany("Candidate_Experience")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FinalProject.Models.Job", b =>
                {
                    b.HasOne("FinalProject.Models.Category", "Category")
                        .WithMany("Jobs")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FinalProject.Models.Company", "Company")
                        .WithMany("Jobs")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FinalProject.Models.Currency", "Currency")
                        .WithMany("Jobs")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FinalProject.Models.Demand", "Demand")
                        .WithMany()
                        .HasForeignKey("DemandId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FinalProject.Models.Location", "Location")
                        .WithMany("Jobs")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FinalProject.Models.Type", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
