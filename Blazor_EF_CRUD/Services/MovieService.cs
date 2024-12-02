using Blazor_EF_CRUD.Context;
using Blazor_EF_CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace Blazor_EF_CRUD.Services
{
    public class MovieService : IMovieService
    {
        private readonly DataContext _context;

        public MovieService(DataContext context)
        {
            _context = context;
        }

        // ------------ READ ------------
        // 全件取得
        public async Task<List<Movie>> GetAllMovies()
        {
            var movies = await _context.Movies.ToListAsync();
            return movies;
        }

        // IDで1件取得
        public async Task<Movie?> GetMovieById(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            return movie;
        }

        // ------------ CREATE ------------
        public async Task<Movie> AddMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();

            return movie;
        }

        // ------------ UPDATE ------------
        public async Task<Movie> EditMovie(int id, Movie newMovie)
        {
            var dbMovie = await _context.Movies.FindAsync(id);
            if (dbMovie == null)
            {
                throw new Exception($"Movie not found ID={id}");
            }

            dbMovie.Title = newMovie.Title;
            dbMovie.ReleaseYear = newMovie.ReleaseYear;

            _context.Movies.Update(dbMovie);
            await _context.SaveChangesAsync();
            return dbMovie;
        }

        // ------------ DELETE ------------
        public async Task DeleteMovie(int id)
        {
            var dbMovie = await _context.Movies.FindAsync(id);
            if (dbMovie == null)
            {
                throw new Exception($"Movie not found ID={id}");
            }
            _context.Remove(dbMovie);
            await _context.SaveChangesAsync();
        }
    }
}
