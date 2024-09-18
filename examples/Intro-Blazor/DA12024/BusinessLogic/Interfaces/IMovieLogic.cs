using BusinessLogic.Models;

namespace BusinessLogic.Interfaces;

public interface IMovieLogic
{
    List<Movie> GetMovies();
    void AddMovie(Movie movie);
    void DeleteMovie(String title);
}