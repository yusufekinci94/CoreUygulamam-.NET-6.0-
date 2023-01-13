using Microsoft.EntityFrameworkCore;

namespace BlogApiUygulama.DataAccessLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-MD5VCD8;database=CoreBlogApiDb; integrated security=true;TrustServerCertificate=True;");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
