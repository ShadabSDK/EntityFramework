using System;
using System.Collections.Generic;
using System.Data.Entity;
using EF.Core.Data;
using EF.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EF.UnitTest
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void StudentCourseTest()
        {
            Database.SetInitializer<EFDbContext>(new CreateDatabaseIfNotExists<EFDbContext>());

            using (var context = new EFDbContext())
            {
                if (!context.Database.Exists())
                {
                    context.Database.Create();
                }
                Student student = new Student
                {
                    Name = "Sandeep",
                    Age = 25,
                    IsCurrent = true,
                    AddedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IP = "1.1.1.1",
                    Courses = new List<Course>{
                        new Course
                        {
                            Name = "Asp.Net",
                            MaximumStrength = 12,
                            AddedDate = DateTime.Now,
                            ModifiedDate = DateTime.Now,
                            IP = "1.1.1.1"
                        },
                         new Course
                        {
                            Name = "SignalR",
                            MaximumStrength = 12,
                            AddedDate = DateTime.Now,
                            ModifiedDate = DateTime.Now,
                            IP = "1.1.1.1"
                        }
                    }
                };
                Course course = new Course
                {
                    Name = "Web API",
                    MaximumStrength = 12,
                    AddedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IP = "1.1.1.1",
                    Students = new List<Student>{
                        new Student
                        {
                            Name = "Raviendra",
                            Age = 25,
                            IsCurrent = true,
                            AddedDate = DateTime.Now,
                            ModifiedDate = DateTime.Now,
                            IP = "1.1.1.1",
                        },
                         new Student
                        {
                          Name = "Pradeep",
                        Age = 25,
                        IsCurrent = true,
                        AddedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IP = "1.1.1.1",
                        }
                    }
                };
                context.Entry(student).State = EntityState.Added;
                context.Entry(course).State = EntityState.Added;
                context.SaveChanges();
            }
        }
    }
}
