using Microsoft.EntityFrameworkCore;
using qaeducationbackend.Dal.Model;
using System.Reflection.Metadata;

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

        public DbSet<UserModel> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SessionModel>()
                .HasOne(e => e.Film)
                .WithMany(e => e.Sessions)
                .HasForeignKey(e => e.FilmId)
                .IsRequired();
        }
    }
}