using SecutiryApp.Models;
using System.Data.Entity;

namespace SecutiryApp.DataAccess
{
    public class SecurityContext : DbContext
    {
        public SecurityContext()
            : base("name=SecurityContext")
        {
            Database.SetInitializer(new DataInitializer());
        }
        
        public DbSet<User> Users { get; set; }
    }
}