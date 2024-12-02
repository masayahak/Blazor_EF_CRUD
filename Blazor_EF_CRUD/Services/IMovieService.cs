using Blazor_EF_CRUD.Models;
namespace Blazor_EF_CRUD.Services
{
    public interface IMovieService
    {
        // ------------ READ ------------
        // 全件取得
        Task<List<Movie>> GetAllMovies();
        // IDで1件取得
        Task<Movie?> GetMovieById(int id);


        // ------------ CREATE ------------
        Task<Movie> AddMovie(Movie movie);
        // ------------ UPDATE ------------
        Task<Movie> EditMovie(int id, Movie movie);
        // ------------ DELETE ------------
        Task DeleteMovie(int id);
    }
}
