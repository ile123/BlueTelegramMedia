using API.DataContext;
using Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace API.Repositories
{
    public class ReviewRepository
    {
        private readonly dbContext _context;
        public ReviewRepository(dbContext context) => _context = context;
        public IEnumerable<Review> GetReviews()
        {
            return _context.Reviews.ToList();
        }
        public IEnumerable<Review> GetReviewesByReviewer(int reviewerId)
        {
            return _context.Reviews.Where(r => r.ReviewerId.Equals(reviewerId)).ToList();
        }
        public IEnumerable<Review> GetReviewesByMovie(int movieId)
        {
            return _context.Reviews.Where(r => r.MovieId.Equals(movieId)).ToList();
        }
        public Review GetReview(int reviewId)
        {
            return _context.Reviews.FirstOrDefault(review => review.Id.Equals(reviewId));
        }
        public void InsertReview(Review review)
        {
            _context.Reviews.Add(review);
            _context.SaveChanges();
        }
        public void UpdateReview(Review review)
        {
            var ReviewForUpdate = GetReview(review.Id);
            if(ReviewForUpdate is not null)
            {
                if(review.Rating != ReviewForUpdate.Rating)
                {
                    ReviewForUpdate.Rating = review.Rating;
                }
                if (!string.IsNullOrEmpty(review.FilmReview))
                {
                    ReviewForUpdate.FilmReview = review.FilmReview;
                }
                _context.SaveChanges();
            }
        }
        public void DeleteReview(int ReviewId)
        {
            var ReviewForDeletion = GetReview(ReviewId);
            if(ReviewForDeletion is not null)
            {
                _context.Reviews.Remove(ReviewForDeletion);
                _context.SaveChanges();
            }
        }
    }
}
