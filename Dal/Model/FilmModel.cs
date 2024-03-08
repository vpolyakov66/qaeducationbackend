namespace qaeducationbackend.Dal.Model
{
    public class FilmModel(int id, string name, int ageRate, bool isEnabled)
    {
        public int Id { get; set; } = id;
        public  string Name { get; set; } = name;
        public int AgeRate { get; set; } = ageRate;
        public bool IsEnabled { get; set; } = isEnabled;
    }
}
