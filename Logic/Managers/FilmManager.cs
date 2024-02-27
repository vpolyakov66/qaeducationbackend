using qaeducationbackend.Model;

namespace qaeducationbackend.Logic.Managers
{
    public class FilmManager
    {

        public List<FilmModel> ListFilm { get; set; } = [
            new(1,"Тители",12,true),
            new(2, "Предотвратители", 2, true),
            new(3, "ПОхитители", 120, true),
            new(4, "Покрорители", 18, false),
            new(5,"Фальшивочники",11,true),
            new(6,"Большой куш",55,true),
        ];

        public FilmManager()
        {
        }
    }
}
