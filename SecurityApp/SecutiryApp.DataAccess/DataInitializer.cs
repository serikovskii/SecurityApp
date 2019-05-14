using SecutiryApp.Models;
using SecutiryApp.Services;
using System.Data.Entity;

namespace SecutiryApp.DataAccess
{
    public class DataInitializer : CreateDatabaseIfNotExists<SecurityContext>
    {
        protected override void Seed(SecurityContext context)
        {
            context.Users.Add(new User
            {
                Login = "admin",
                Password = EncryptionService.HashPassword("123")
            });
        }
    }
}
