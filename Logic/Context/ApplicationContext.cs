using Microsoft.EntityFrameworkCore;
using qaeducationbackend.Logic.Managers;
using qaeducationbackend.Model;

namespace qaeducationbackend.Logic.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<SessionModel> Sessions { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options) 
            : base(options)
        {
            Database.EnsureCreated(); // Создаём базу при первом обращении
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SessionModel>().HasData(
                    new SessionModel { Id = 1, SessionDate = new DateTime(12, 12, 12), ClientName = "Дядя",Film = new FilmManager().ListFilm[0] },
                    new SessionModel { Id = 2, SessionDate = new DateTime(12, 12, 12), ClientName = "Тима", Film = new FilmManager().ListFilm[1] },
                    new SessionModel { Id = 3, SessionDate = new DateTime(12, 12, 12), ClientName = "Вова", Film = new FilmManager().ListFilm[2] }
            );
        }
    }
}
