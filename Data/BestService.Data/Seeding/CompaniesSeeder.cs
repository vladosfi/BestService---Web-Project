﻿namespace BestService.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BestService.Common;
    using BestService.Data.Models;

    public class CompaniesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Companies.Any())
            {
                return;
            }

            var companies = new List<(string Name, string Description, float Rating, string LogoImage, string OfficialSite, string Category)>
            {
                  ("MentorMate Bulgaria Ltd.", "An industry veteran, MentorMate meets complex business challenges with native, hybrid, and custom software development. We think big, design smart, and develop fast for all screens, projects, and teams. We scale quickly and manage all stages of the software lifecycle, including ideation, architecture, design, development, and quality assurance.We have been developing software solutions since 2001 and have established skills across 30+ development languages and 10 technical practices. Our 500-people-strong software development team works closely with our clients to build effective and robust experiences, which include client-server solutions, mobile and desktop applications, modules and libraries, and cross-browser web-based solutions.With our headquarters in Minneapolis, Minnesota, we have an office in Gothenburg, Sweden, and five development offices in Bulgaria — in Sofia, Plovdiv, Varna, Veliko Tarnovo, and Ruse. In addition, we offer full-time remote opportunities to those who would like to work for us from any part of the world, as well as part - time options for contractors through the MentorMate Partner Network platform.", 3, "v1586687107/aszxvpancd8nxbsukhdf.jpg", "https://mentormate.com/", "IT"), ("Business Services and Technologies OOD", "Europe's largest technology company - SAP SE announced Business Services and Technologies OOD (BST) as its gold partner in Bulgaria. The software leader grants this status to companies that have proven their competence in the delivery, implementation and maintenance of SAP solutions.The company offers complex solutions including business consulting, IT infrastructure development, implementation and support of SAP solutions. To be able to meet customers’ business requirements and to be its customers’ reliable partner on their way to digital transformation, BST has built key competencies in some of SAP's most innovative solutions for business processes management. In addition, BST has the ambition to become one of the most innovative companies not only in Bulgaria, but also on the international market and has focused on expanding its portfolio, including SAP S/4 HANA Cloud, SAP Cloud Platform and Internet of Things (IoT).", 3.3f, "v1586687202/cjgn1gcsay5sefruh6ba.jpg", "https://www.bst.bg", "IT"), ("CredoWeb", "CredoWeb is an innovative social network for health. We connect physicians, dentists, pharmacists, patients, medical centers and organizations. The platform provides interactive communication and information for everyone for whom health is quality of life. Through CredoWeb users can quickly and easily find their physician. Medical specialists can share their achievements, answer patients’ questions and connect with colleagues.", 2.3f, "v1586687534/aisblr8sxfhm5dttwhhi.jpg", "https://www.credoweb.bg/", "Healthcare"), ("Pontica Solutions", "Pontica Solutions is a Stevie® award-winning BPO and ITO company, founded as a start-up in 2015 by experienced professionals in the industry. We offer a variety of opportunities for young talent to develop and grow in the field of customer success, people management, project management, marketing and IT. Our main goal is to create a sustainable and diverse team because we believe that our people are our biggest asset.Today, we partner with companies in the field of technology, gaming, e-commerce, and retail and keep expanding our portfolio at a very high pace.", 4.3f, "v1585827051/knk0ecqh3qmy8996g0jg.jpg", "https://www.credoweb.bg/", "Transport"), ("CBS", "CBS Corporation (CBS) has an annual net income of approximately $2 billion. It owns the CBS TV broadcast network and related distribution and production facilities, CBS Radio, CBS Records and CBS Sports. It also owns the Showtime premium cable channel. Like many of its competitors, CBS is working to remain successful with the cord-cutting generation. Changes include adding a fee-based on-demand component to its broadcast TV shows to enable and profit from viewers who choose to watch shows at a later date. Sumner Redstone owns a controlling interest in CBS.", 1.3f, "v1585827051/knk0ecqh3qmy8996g0jg.jpg", "https://www.cbs.com/", "Entertainment"), ("AGRI-HR LTD", "At AGRI-HR we help people from around the world find permanent or seasonal jobs in the UK & Europe.Jobs include fruit and vegetable harvesting, livestock management, packhouse and general farm work as well as junior management or skilled positions.Our ethos.We have built our business around focusing on the people we work with. We believe in only working with farms and employers who match our welfare expectations, in return we will only select the most suitable candidates to fill roles.Operating Europe-wide - Currently we have placements in UK, Jersey, Germany, Holland, Belgium and Ireland.", 2.3f, "v1585827051/knk0ecqh3qmy8996g0jg.jpg", "http://www.agri-hr.com/", "Agriculture"), ("Adecco", "What do we do at Adecco? Well, to put it simply, on any given day we connect over 700,000 people across 60 countries with job opportunities at leading employers. But our goal goes beyond filling roles - it’s about helping people find fulfilling work and, ultimately, love what they do. If you’re looking for new job opportunities, Adecco can give you access to more jobs at more companies than anyone else. In addition, we can provide the resources you need to realize your career goals.", 3.3f, "v1585827051/knk0ecqh3qmy8996g0jg.jpg", "https://www.credoweb.bg/", "Art"), ("AbeloHost B.V.", "AbeloHost is a web hosting provider established in the year 2012 in the Netherlands. We provide our clients with hosting solutions, dedicated servers and co-location with world-class security. With a globalized vision, the company aims to provide reliable hosting solutions and affordable prices to all its international clients.", 4.3f, "v1585827051/knk0ecqh3qmy8996g0jg.jpg", "http://www.abelohost.com/", "Education"), ("FirstPlay", "FirstPlay is a Sports Data Company consisting of many of the most experienced experts in the field, who feel there is a good market for modern and flexible data delivery. We deliver high-quality sports updates in real-time from stadiums and with unmatched speed and performance.", 3.2f, "v1585827051/knk0ecqh3qmy8996g0jg.jpg", "https://firstplay.io/", "Sport"), ("GFS Engineering", "Bulgaria LLC conducting activity in the field of engineering, technical consulting and implementation of construction projects is looking for a Civil Engineer to work as a Site Engineer in a project located in Sofia.", 3.1f, "v1585827051/knk0ecqh3qmy8996g0jg.jpg", "http://gfs-eng.com/", "Construction"), ("Tek Experts", "Tek Experts is a global IT services provider with operations in Europe, America, Asia and Africa. We opened our Bulgaria site in 2010 and already employ more than 900 people. And we are growing day-by-day. We are at the forefront of business and IT support in the region and are committed to developing our people and our operations for the long term. By joining Tek Experts Bulgaria, you can learn with us, grow with us and become part of our journey to greatness.", 4.1f, "v1585827051/knk0ecqh3qmy8996g0jg.jpg", "https://www.tek-experts.com/", "Tourism"), ("AIR TRADE COMPANY", "In Air Trade Company Ltd. we import and distribute a wide range of materials and equipment for HVAC installations on the Bulgarian market. Our clients are installer firms who do ventilation, split system, VRF heat pump installation, and more. Our goal is to supply good quality products at competitive prices. We are the official representative for TROX in Bulgaria, also among our partners are well known brands such as WILO, Viega, Oventrop and more", 3.5f, "v1585827051/knk0ecqh3qmy8996g0jg.jpg", "https://airtradecompany.com/", "Trade"), ("ManpowerGroup", "ManpowerGroup is the world leader in innovative workforce solutions, connecting human potential to the power of business. ManpowerGroup serves both large and small organizations across all industry sectors through our brands and offerings: Manpower, Experis and Talent Solutions.", 1.7f, "v1586687053/fhrfip3wf6jnlb3vw0za.png", "http://www.manpower.bg/", "Services"),
            };

            var category = dbContext.Categories.ToList();
            var companiesList = new List<Company>();

            for (int i = 0; i < 10; i++)
            {
                foreach (var company in companies)
                {
                    companiesList.Add(new Company
                    {
                        Name = company.Name,
                        Description = company.Description,
                        LogoImage = company.LogoImage,
                        OfficialSite = company.OfficialSite,
                        CategoryId = category.Where(x => x.Name == company.Category).Select(x => x.Id).FirstOrDefault(),
                        User = this.GetUserByUserName(dbContext, GlobalConstants.CompanyEmail),
                    });
                }
            }

            await dbContext.Companies.AddRangeAsync(companiesList);
        }

        private ApplicationUser GetUserByUserName(ApplicationDbContext dbContext, string userName)
        {
            return dbContext.Users.Where(x => x.UserName == userName).FirstOrDefault();
        }
    }
}
