using API.DataContext;
using Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace API.Repositories
{
    public class MovieRepository
    {
        private readonly dbContext _context;
        public MovieRepository(dbContext context) => _context = context;
        public IEnumerable<Movie> GetMovies()
        {
            return _context.Movies.ToList();
        }
        public Movie GetMovie(int MovieId)
        {
            return _context.Movies.FirstOrDefault(movie => movie.Id.Equals(MovieId));
        }
        public void InsertMovide(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }
    }
}
