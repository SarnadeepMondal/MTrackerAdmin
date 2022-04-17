using Microsoft.EntityFrameworkCore;
using MTrackerAdmin.Model;

namespace MTrackerAdmin.Data
{
    public class ApplicatonDbContext : DbContext
    {
        public ApplicatonDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Organization> Organization { get; set; }
    }
}
