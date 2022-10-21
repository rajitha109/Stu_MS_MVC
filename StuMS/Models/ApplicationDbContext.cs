using Microsoft.EntityFrameworkCore;
namespace StuMS.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<NewStuModel> Student { get; set; }
        public DbSet<NewMarkModel> Marks { get; set; }


    }
}
