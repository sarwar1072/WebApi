using Microsoft.EntityFrameworkCore;
using WebAPI.Web.Models;

namespace WebAPI.Web.Context
{
    public class ApplicationDbContext:DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
                
        }
        public DbSet<Post> Posts { get; set; }  
    }
}
