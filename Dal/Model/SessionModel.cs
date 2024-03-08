namespace qaeducationbackend.Dal.Model
{
    public class SessionModel
    {
        public int Id { get; set; }
        public DateTime SessionDate { get; set; }
        public string ClientName { get; set; }
        public FilmModel Film { get; set; }
    }
}
