using BusinessLogic.Interfaces;
using Domain;
using Dtos;

namespace BusinessLogic;

public class MovieLogic: IMovieLogic
{
    private List<Movie> _movieList;

    public MovieLogic()
    {
        _movieList = new List<Movie>();
    }
    
    public List<MovieDto> GetMovies()
    {
        return _movieList.Select(x=> x.ToMovieDto()).ToList();
    }

    public void AddMovie(MovieDto movieDto)
    {
        var movie = new Movie(movieDto);
        ValidateMovieTitle(movie.Title);
        _movieList.Add(movie);
    }

    public void DeleteMovie(string title)
    {
        var movie =_movieList.Where(x => x.Title == title).FirstOrDefault();
        if (movie == null)
        {
            throw new ArgumentException("Entity not found");
        }
        _movieList.Remove(movie);
    }

    public void UpdateMovie(MovieDto movieToUpdate)
    {
        var movieToUpdateIndex = _movieList.IndexOf(_movieList.Find(m => m.Title == movieToUpdate.Title));
        _movieList[movieToUpdateIndex] = new Movie(movieToUpdate);
    }

    public MovieDto SearchMovieByTitle(String title)
        {
            Movie movie = _movieList.FirstOrDefault(movie => movie.Title == title);
            if (movie == null)
            {
                throw new ArgumentException("Cannot find movie with this title");
            }
            return movie.ToMovieDto();
        }

    private void ValidateMovieTitle(String title)
    {
        foreach (var m in _movieList)
        {
            if (m.Title == title)
            {
                throw new ArgumentException("Movie title already exists");
            }
        }

    }
}