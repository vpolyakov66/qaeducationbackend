using qaeducationbackend.Dal.Model;

namespace qaeducationbackend.Dal.Repository.Interface
{
    public interface ISessionRepository
    {
       public void SeedData();

       public List<SessionModel> GetList();

       public void Add(SessionModel value);
    }
}