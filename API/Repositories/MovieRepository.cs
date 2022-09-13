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

        public Movie GetMovieByName(string nameMovie)
        {
            return _context.Movies.FirstOrDefault(movie => movie.Name.Equals(nameMovie));
        }

        public void InsertMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }
        public void UpdateMovie(Movie movie)
        {
            var MovieForUpdate = GetMovie(movie.Id);
            if(MovieForUpdate is not null)
            {
                if (!string.IsNullOrEmpty(movie.Name))
                {
                    MovieForUpdate.Name = movie.Name;
                }
                if (!string.IsNullOrEmpty(movie.Description))
                {
                    MovieForUpdate.Description = movie.Description;
                }
                if (!string.IsNullOrEmpty(movie.Writers))
                {
                    MovieForUpdate.Writers = movie.Writers;
                }
                if (!string.IsNullOrEmpty(movie.Actors))
                {
                    MovieForUpdate.Actors = movie.Actors;
                }
                if (!string.IsNullOrEmpty(movie.Picture))
                {
                    MovieForUpdate.Picture = movie.Picture;
                }
                if (!string.IsNullOrEmpty(movie.Genre))
                {
                    MovieForUpdate.Genre = movie.Genre;
                }
                _context.SaveChanges();
            }
        }
        public void DeleteMovie(int MovieId)
        {
            var MovieForDeletion = GetMovie(MovieId);
            if(MovieForDeletion is not null)
            {
                _context.Movies.Remove(MovieForDeletion);
                _context.SaveChanges();
            }
        }
    }
}
