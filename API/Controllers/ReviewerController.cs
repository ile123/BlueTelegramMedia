using API.Repositories;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewerController : ControllerBase
    {
        private readonly ReviewerRepository _repo;
        public ReviewerController(ReviewerRepository repo) => _repo = repo;
        [HttpGet]
        public IActionResult GetReviewers()
        {
            try
            {
                var reviewers = _repo.GetReviewers();
                return Ok(reviewers);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpGet("{reviewerId:int}")]
        public IActionResult GetReviewer(int reviewerId)
        {
            try
            {
                return Ok(_repo.GetReviewer(reviewerId));
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpGet("{reviewerUsername}")]
        public IActionResult GetReviewerByUsername(string reviewerUsername)
        {
            try
            {
                return Ok(_repo.GetReviewerByUsername(reviewerUsername));
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPost]
        public IActionResult AddReviewer([FromBody] Reviewer reviewer)
        {
            if (reviewer is null) { return BadRequest(); }
            try
            {
                _repo.InsertReviewer(reviewer);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPut]
        public IActionResult UpdateReviewer([FromBody] Reviewer reviewer)
        {
            if (reviewer is null) { return BadRequest(); }
            try
            {
                _repo.UpdateReviewer(reviewer);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpDelete("{reviewerId:int}")]
        public IActionResult DeleteReviewer(int reviewerId)
        {
            try
            {
                _repo.DeleteReviewer(reviewerId);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
