using API.DataContext;
using Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace API.Repositories
{
    public class ReviewerRepository
    {
        private readonly dbContext _context;

        public ReviewerRepository(dbContext context) => _context = context;

        public IEnumerable<Reviewer> GetReviewers()
        {
            return _context.Reviewers.ToList();
        }

        public Reviewer GetReviewer(int ReviewerId)
        {
            return _context.Reviewers.FirstOrDefault(reviewer => reviewer.Id.Equals(ReviewerId));
        }

        public Reviewer GetReviewerByUsername(string username)
        {
            return _context.Reviewers.FirstOrDefault(reviewer => reviewer.Username.Equals(username));
        }

        public void InsertReviewer(Reviewer reviewer)
        {
            _context.Reviewers.Add(reviewer);
            _context.SaveChanges();
        }
        public void UpdateReviewer(Reviewer reviewer)
        {
            var ReviewerForUpdate = GetReviewer(reviewer.Id);
            if (ReviewerForUpdate is not null)
            {
                if (!string.IsNullOrEmpty(reviewer.Username))
                {
                    ReviewerForUpdate.Username = reviewer.Username;
                }
                if (!string.IsNullOrEmpty(reviewer.Email))
                {
                    ReviewerForUpdate.Email = reviewer.Email;
                }
                if (!string.IsNullOrEmpty(reviewer.Password))
                {
                    ReviewerForUpdate.Password = reviewer.Password;
                }
                _context.SaveChanges();
            }
        }
        public void DeleteReviewer(int ReviewerId)
        {
            var ReviewerForDeletion = GetReviewer(ReviewerId);
            if (ReviewerForDeletion is not null)
            {
                _context.Reviewers.Remove(ReviewerForDeletion);
                _context.SaveChanges();
            }
        }
    }
}
