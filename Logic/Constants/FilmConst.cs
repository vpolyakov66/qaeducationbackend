using qaeducationbackend.Dal.Model;

namespace qaeducationbackend.Logic.Constants
{
    public static class FilmConst
    {
        public static List<FilmModel> Films = new()
        {
            new(1, "Тители", 12, true),
            new(2, "Предотвратители", 2, true),
            new(3, "ПОхитители", 120, true),
        };
    }
}