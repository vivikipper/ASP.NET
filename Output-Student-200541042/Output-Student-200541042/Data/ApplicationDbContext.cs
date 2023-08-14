using Microsoft.EntityFrameworkCore;
using Output_Student_200541042.Models;

namespace Output_Student_200541042.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; } 
    }
}
