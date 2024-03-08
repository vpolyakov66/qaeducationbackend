using Microsoft.EntityFrameworkCore;
using qaeducationbackend.Dal.Model;

namespace qaeducationbackend.Dal.DbContext
{
    public class ApiDbContext  : Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "ApiDb");
        }

        public DbSet<SessionModel> Sessons { get; set; }

        public DbSet<FilmModel> Films { get; set; }
    }
}