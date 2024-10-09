using BusinessLogic.DataAccess;
using BusinessLogic.Interfaces;
using Domain;
using Dtos;

namespace BusinessLogic;

public class MovieLogic: IMovieLogic
{
    private MemoryDB _memoryDB;

    public MovieLogic(MemoryDB memoryDB)
    {
        _memoryDB = memoryDB;
    }
    
    public List<MovieDto> GetMovies()
    {
        List<MovieDto> moviesDTO = new List<MovieDto>();

        foreach (var movie in _memoryDB.Movies)
        {
            moviesDTO.Add(MovieDto.FromEntity(movie));
        }
        return moviesDTO;
    }

    public void AddMovie(MovieDto movie)
    {
        //ValidateMovieTitle(movie.Title);

        _memoryDB.Movies.Add(movie.ToEntity());
    }

    public void DeleteMovie(string title)
    {
        Movie movie = GetMovie(title);
        _memoryDB.Movies.Remove(movie);
    }

    public void UpdateMovie(MovieDto movieToUpdate)
    {
        var movieToUpdateIndex = _memoryDB.Movies.IndexOf(_memoryDB.Movies.Find(m => m.Title == movieToUpdate.Title));

        if (String.IsNullOrEmpty(movieToUpdate.Director))
        {
            throw new ArgumentException("Movie director cannot be empty or null");
        }

        _memoryDB.Movies[movieToUpdateIndex] = movieToUpdate.ToEntity();
    }

    public MovieDto SearchMovieByTitle(String title)
    {
        Movie movie = _memoryDB.Movies.FirstOrDefault(movie => movie.Title == title);
        if (movie == null)
        {
            throw new ArgumentException("Cannot find movie with this title");
        }
        return MovieDto.FromEntity(movie);
    }

    private void ValidateMovieTitle(String title)
    {
        foreach (var movie in _memoryDB.Movies)
        {
            if (movie.Title == title)
            {
                throw new ArgumentException("There`s a movie already defined with that title");
            }
        }
    }

    private Movie GetMovie(string title)
    {
        Movie movie = _memoryDB.Movies.FirstOrDefault(movie => movie.Title == title);
        if (movie == null)
        {
            throw new ArgumentException("Cannot find movie with this title");
        }
        return movie;
    }
}