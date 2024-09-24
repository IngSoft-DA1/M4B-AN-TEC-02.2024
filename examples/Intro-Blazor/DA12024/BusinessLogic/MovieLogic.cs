using BusinessLogic.DataAccess;
using BusinessLogic.Interfaces;
using BusinessLogic.Models;

namespace BusinessLogic;

public class MovieLogic: IMovieLogic
{
    private MemoryDB _memoryDB;

    public MovieLogic(MemoryDB memoryDB)
    {
        _memoryDB = memoryDB;
    }
    
    public List<Movie> GetMovies()
    {
        return _memoryDB.Movies;
    }

    public void AddMovie(Movie movie)
    {
        ValidateMovieTitle(movie.Title);
        _memoryDB.Movies.Add(movie);
    }

    public void DeleteMovie(string title)
    {
        Movie movie = SearchMovieByTitle(title);
        _memoryDB.Movies.Remove(movie);
    }

    public void UpdateMovie(Movie movieToUpdate)
    {
        var movieToUpdateIndex = _memoryDB.Movies.IndexOf(_memoryDB.Movies.Find(m => m.Title == movieToUpdate.Title));
        _memoryDB.Movies[movieToUpdateIndex] = movieToUpdate;
    }

    public Movie SearchMovieByTitle(String title)
        {
            Movie movie = _memoryDB.Movies.FirstOrDefault(movie => movie.Title == title);
            if (movie == null)
            {
                throw new ArgumentException("Cannot find movie with this title");
            }
            return movie;
        }

    private void ValidateMovieTitle(String title)
    {
        foreach (var m in _memoryDB.Movies)
        {
            if (m.Title == title)
            {
                throw new ArgumentException("Movie title already exists");
            }
        }
    }
}