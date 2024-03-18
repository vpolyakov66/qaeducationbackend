
namespace qaeducationbackend.Dal.Model
{
    public class SessionModel
    {
        public int Id { get; set; }
        public DateTime SessionDate { get; set; }
        public string ClientName { get; set; }
        public int AgeClient { get; set; }    
        public FilmModel Film { get; set; }
        public int FilmId { get; set; }

        public static implicit operator List<object>(SessionModel v)
        {
            throw new NotImplementedException();
        }
    }
}
