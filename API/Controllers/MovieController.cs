using API.Repositories;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly MovieRepository _repo;
        public MovieController(MovieRepository repo) => _repo = repo;
        [HttpGet]
        public IActionResult GetMovies()
        {
            try
            {
                var movies = _repo.GetMovies();
                return Ok(movies);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpGet("{movieId:int}")]
        public IActionResult GetMovie(int movieId)
        {
            try
            {
                return Ok(_repo.GetMovie(movieId));
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpGet("{movieName}")]
        public IActionResult GetMovieByName(string movieName)
        {
            try
            {
                return Ok(_repo.GetMovieByName(movieName));
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPost]
        public IActionResult AddMovie([FromBody] Movie movie)
        {
            if (movie is null) { return BadRequest(); }
            try
            {
                _repo.InsertMovie(movie);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPut]
        public IActionResult UpdateMovie([FromBody] Movie movie)
        {
            if (movie is null) { return BadRequest(); }
            try
            {
                _repo.UpdateMovie(movie);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpDelete("{movieId:int}")]
        public IActionResult DeleteMovie(int movieId)
        {
            try
            {
                _repo.DeleteMovie(movieId);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
