
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp304.Models
{
    public static class SeedDatabase
    {
        public static void Seed(DbContext context)
        {
            if (!context.Database.GetPendingMigrations().Any())
            {
                if (context is DataContext)
                {
                    DataContext _context = context as DataContext;
                    if (!_context.Courses.Any()/*_context.Courses.Count()==0*/)
                    {
                        _context.Courses.AddRange(Courses);
                    }
                    if (!_context.Instructors.Any()/*_context.Instructors.Count()==0*/)
                    {
                        _context.Instructors.AddRange(Instructors);
                    }
                    if (!_context.Students.Any())
                    {
                        _context.Students.AddRange(Students);
                    }
                }
                if (context is UserContext)
                {
                    UserContext _context = context as UserContext;
                    if (!_context.Users.Any()/*_context.Users.Count()==0*/)
                    {
                        _context.Users.AddRange(Users);
                    }
                }
                context.SaveChanges();
            }
        }
        private static Course[] Courses
        {
            get
            {
                Course[] courses = new Course[]
                {
                new Course() {Name="Html",Price=10,Description="about Html",isActive=true,Instructor=Instructors[0]},
                new Course() {Name="Css",Price=100,Description="about Css",isActive=false,Instructor=Instructors[1]},
                new Course() {Name="JavaScript",Price=70,Description="about JavaScript",isActive=false,Instructor=Instructors[2]},
                new Course() {Name="NodeJs",Price=90,Description="about NodeJs",isActive=false,Instructor=Instructors[3]},
                new Course() {Name="Angular",Price=200,Description="about Angular",isActive=true,Instructor=Instructors[4]},
                new Course() {Name="React",Price=150,Description="about React",isActive=false,Instructor=Instructors[5]},
                new Course() {Name="Asp.Net.Mvc",Price=400,Description="about Asp.Net.Mvc",isActive=true,Instructor=Instructors[0]},
                new Course() {Name="Asp.Net.Core",Price=600,Description="about Asp.Net.Core",isActive=true,Instructor=Instructors[0]}
                };
                return courses;
            }
        }

        private static Student[] Students 
        {
            get
            {
                Student[] students = new Student[]
                {
                    new Student() {Name="Student1"},
                    new Student() {Name="Student2"},
                    new Student() {Name="Student3"},
                    new Student() {Name="Student4"},
                    new Student() {Name="Student5"}
                };
                return students;
            }
        }

        private static Instructor[] Instructors =
        {
            new Instructor(){ Name="Onur Ağıcı",Contact=new Contact(){ Email="onur@gmail.com",Phone="12345",Address=new Address(){City="Ankara",Country="Türkiye",Text="PiriReis Mah." } }},
            new Instructor(){ Name="Selin Ağıcı",Contact=new Contact(){ Email="selin@gmail.com",Phone="234",Address=new Address(){City="Istanbul",Country="Türkiye",Text="PiriReis Mah." } }},
            new Instructor(){ Name="Serpil Ağıcı",Contact=new Contact(){ Email="serpil@gmail.com",Phone="456",Address=new Address(){City="Sivas",Country="Türkiye",Text="PiriReis Mah." } }},
            new Instructor(){ Name="Nurcihan Ağıcı",Contact=new Contact(){ Email="nurcihan@gmail.com",Phone="678",Address=new Address(){City="Rize",Country="Türkiye",Text="PiriReis Mah." } }},
            new Instructor(){ Name="Tahir Ağıcı",Contact=new Contact(){ Email="tahir@gmail.com",Phone="890",Address=new Address(){City="Çorum",Country="Türkiye",Text="PiriReis Mah." } }},
            new Instructor(){ Name="Orkun Ağıcı",Contact=new Contact(){ Email="orkun@gmail.com",Phone="345",Address=new Address(){City="Diyarbakır",Country="Türkiye",Text="PiriReis Mah." } }},
            new Instructor(){ Name="Mira Ağıcı",Contact=new Contact(){ Email="mira@gmail.com",Phone="368",Address=new Address(){City="Istanbul",Country="Türkiye",Text="PiriReis Mah." } }},
            new Instructor(){ Name="Görkem Ağıcı",Contact=new Contact(){ Email="gorkem@gmail.com",Phone="156",Address=new Address(){City="Ankara",Country="Türkiye",Text="PiriReis Mah." } }},
        };

        private static User[] Users =
        {
            new User(){UserName="onuragici",Email="onur@gmail.com",Password="12345",City="İstanbul"},
            new User(){UserName="selinagici",Email="selin@gmail.com",Password="12345",City="İstanbul"},
            new User(){UserName="serpilagici",Email="serpil@gmail.com",Password="12345",City="İstanbul"}
        };
    }
    
}
