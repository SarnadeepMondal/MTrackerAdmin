using Microsoft.EntityFrameworkCore;
using MTrackerAdminWeb.Models;

namespace MTrackerAdminWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Organization> Organization { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
    }
}
