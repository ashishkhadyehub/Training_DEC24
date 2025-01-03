
using Microsoft.EntityFrameworkCore;
using NetCore_Sessions.Models;

namespace NetCore_Sessions.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<Students> Students { get; set; }


    }


}
