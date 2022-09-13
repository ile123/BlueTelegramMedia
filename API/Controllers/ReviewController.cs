using API.Repositories;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly ReviewRepository _repo;
        public ReviewController(ReviewRepository repo) => _repo = repo;
        [HttpGet]
        public IActionResult GetReviews()
        {
            try
            {
                var reviews = _repo.GetReviews();
                return Ok(reviews);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpGet("{reviewId:int}")]
        public IActionResult GetReview(int reviewId)
        {
            try
            {
                return Ok(_repo.GetReview(reviewId));
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        
        [HttpGet("reviewer/{reviewsByReviewerId:int}")]
        public IActionResult GetReviewesByReviewer(int revieByReviewerId)
        {
            try
            {
                return Ok(_repo.GetReviewesByReviewer(revieByReviewerId));
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpGet("movie/{reviewsByMovieId:int}")]
        public IActionResult GetReviewesByMovie(int reviewByMovieId)
        {
            try
            {
                return Ok(_repo.GetReviewesByMovie(reviewByMovieId));
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        
        [HttpPost]
        public IActionResult AddReview([FromBody] Review review)
        {
            if (review is null) { return BadRequest(); }
            try
            {
                _repo.InsertReview(review);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPut]
        public IActionResult UpdateReview([FromBody] Review review)
        {
            if (review is null) { return BadRequest(); }
            try
            {
                _repo.UpdateReview(review);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpDelete("{reviewId:int}")]
        public IActionResult DeleteReview(int reviewId)
        {
            try
            {
                _repo.DeleteReview(reviewId);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
