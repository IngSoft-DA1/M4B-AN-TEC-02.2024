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
        if (String.IsNullOrEmpty(movie.Title))
        {
            throw new ArgumentException("Movie title cannot be null or empty");
        }
        if (String.IsNullOrEmpty(movie.Director))
        {
            throw new ArgumentException("Movie director cannot be null or empty");
        }
        
        ValidateMovieTitle(movie.Title);
        _memoryDB.Movies.Add(movie);
    }

    public void DeleteMovie(string title)
    {
        Movie movie = FindMovieByTitle(title);
        _memoryDB.Movies.Remove(movie);
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
    
    private Movie FindMovieByTitle(String title)
    {
        Movie movie = _memoryDB.Movies.FirstOrDefault(movie => movie.Title == title);
        if (movie == null)
        {
            throw new ArgumentException("Cannot find movie with this title");
        }
        return movie;
    }
}