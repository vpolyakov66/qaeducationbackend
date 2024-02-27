using Microsoft.AspNetCore.Mvc;
using qaeducationbackend.Logic.Managers;
using qaeducationbackend.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace qaeducationbackend.Controllers
{
[Route("api/booking")]
[ApiController]
public class BookingController : ControllerBase
    {
        // GET: /list
        [HttpGet("/list/session")]
        public List<SessionModel> GetSession()
        {
            var sessionModelList = new List<SessionModel>() { new(), new(), new(), new() };
            return sessionModelList;
        }
        // GET: api/list/film
        [HttpGet("/list/film")]
        public List<FilmModel> GetFilms()
        {
            var filmList = new FilmManager().ListFilm;
            return filmList;
        }

        // GET api/<BookingController>/5
        [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

        // POST api/<BookingController>
        [HttpPost]
    public void Post([FromBody] string value)
    {
    }

        // PUT api/<BookingController>/5
        [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

        // DELETE api/<BookingController>/5
        [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
}
