using Microsoft.EntityFrameworkCore;

namespace gachiBlazorServer.Data.Models
{
    public class GachiDbContext : DbContext
    {
        public GachiDbContext( DbContextOptions<GachiDbContext> options ) : base( options ) { }

        public DbSet<Organization> Organizations { get; set; }
        public DbSet<OrganizationAddress> OrganizationAddresses { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
