using qaeducationbackend.Dal.Model;

namespace qaeducationbackend.Logic.Constants
{
    public static class FilmConst
    {
        public static List<FilmModel> Films = new()
        {
            new(1, "Титаник", 18, true),
            new(2, "История игрушек", 0, true),
            new(3, "Человек-паук", 12, true),
        };
    }
}