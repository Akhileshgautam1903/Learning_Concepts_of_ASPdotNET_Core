using Learning_Concepts_of_ASPdotNET_Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Learning_Concepts_of_ASPdotNET_Core.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //This represents the Students table in the database
        public DbSet<Student> Students { get; set; }
    }
}
