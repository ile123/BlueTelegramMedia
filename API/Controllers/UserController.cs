using API.Repositories;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserRepository _repo;
        public UserController(UserRepository repo) => _repo = repo;

        [HttpGet]
        public IActionResult GetUsers()
        {
            try
            {
                var users = _repo.GetUsers();
                return Ok(users);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpGet("{userId:int}")]
        public IActionResult GetUser(int userId)
        {
            try
            {
                return Ok(_repo.GetUser(userId));
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{username}")]
        public IActionResult GetUserByUserName(string username)
        {
            try
            {
                return Ok(_repo.GetUserByUsername(username));
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] User user)
        {
            if (user is null) { return BadRequest(); }
            try
            {
                _repo.InsertUser(user);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPut]
        public IActionResult UpdateUser([FromBody] User user)
        {
            if (user is null) { return BadRequest(); }
            try
            {
                _repo.UpdateUser(user);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpDelete("{userId:int}")]
        public IActionResult DeleteUser(int userId)
        {
            try
            {
                _repo.DeleteUser(userId);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
