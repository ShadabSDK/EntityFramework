using System;
using System.Data.Entity;
using EF.Data;
using EF.Core.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EF.UnitTest
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void UserUserProfileTest()
        {
            
                Database.SetInitializer<EFDbContext>(new CreateDatabaseIfNotExists<EFDbContext>());

                using (var context = new EFDbContext())
                {
                    if (!context.Database.Exists())
                    {
                        context.Database.Create();
                    }

                User user = new User
                {
                    UserName = "ShadabJhansi",
                    Password = "123",
                    Email = "sxyz@test.com",
                    AddedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IP = "1.1.1.1",
                    UserProfile = new UserProfile
                    {
                        FirstName = "Shadab",
                        LastName = "Khan",
                        Address = "Jhansi",
                        AddedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IP = "1.1.1.1"
                    },
                };
                context.Entry(user).State = EntityState.Added;
                context.SaveChanges();
            }
            
        }
    }
}
