using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using qaeducationbackend.Dal.Model;
using qaeducationbackend.Dal.Repository.Interface;
using qaeducationbackend.Logic.Constants;
using qaeducationbackend.Logic.Managers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace qaeducationbackend.Controllers
{
    [Route("api/booking")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly ISessionRepository _sessionRepository;

        public BookingController(ISessionRepository sessionRepository)
        {
            _sessionRepository = sessionRepository;
        }

        // GET: /list
        [HttpGet("/list/session")]
        public List<SessionModel> GetSession()
        {
           return _sessionRepository.GetList();
        }

        // GET: api/list/film
        [HttpGet("/list/film")]
        public List<FilmModel> GetFilms()
        {
            return FilmConst.Films;
        }

        // POST api/<BookingController>
        [HttpPost]
        public void CreateSession([FromBody] SessionModel value)
        {
            _sessionRepository.Add(value);
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