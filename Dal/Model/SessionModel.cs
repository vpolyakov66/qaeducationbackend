using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qaeducationbackend.Model
{
    public class SessionModel
    {
        
        public int Id { get; set; }
        public DateTime SessionDate { get; set; }
        public string ClientName { get; set; }
        public FilmModel Film { get; set; }
        public SessionModel() {
            Id = 1;
            SessionDate = new DateTime(12, 12, 12);
            ClientName = "Тимофей";
            Film = new FilmModel(1, "Бригада", 4, true);
        }
    }
}
