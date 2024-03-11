using Microsoft.EntityFrameworkCore;
using qaeducationbackend.Dal.DbContext;
using qaeducationbackend.Dal.Model;
using qaeducationbackend.Dal.Repository.Interface;
using qaeducationbackend.Logic.Constants;

namespace qaeducationbackend.Dal.Repository
{
    public class SessionRepository : ISessionRepository
    {
        public void SeedData()
        {
            using var context = new ApiDbContext();
            var sessions = new List<SessionModel>
            {
                new()
                {
                    Id = 1,
                    SessionDate = new DateTime(12, 12, 12),
                    ClientName = "Дядя",
                    Film =   new(1, "Тители", 12, true),
                },
                new()
                {
                    Id = 2,
                    SessionDate = new DateTime(12, 12, 12),
                    ClientName = "Тима",
                    Film = FilmConst.Films[1],
                },
                new()
                {
                    Id = 3,
                    SessionDate = new DateTime(12, 12, 12),
                    ClientName = "Вова",
                    Film = FilmConst.Films[2],
                }
            };
            context.Sessons.AddRange(sessions);
            context.SaveChanges();
        }

        public List<SessionModel> GetList()
        {
            using var context = new ApiDbContext();
            return context.Sessons.Include(t=> t.Film).ToList();
        }

        public void Add(SessionModel value)
        {
            using var context = new ApiDbContext();
            context.Sessons.AddRange(value);
            context.SaveChanges();
        }
    }
}