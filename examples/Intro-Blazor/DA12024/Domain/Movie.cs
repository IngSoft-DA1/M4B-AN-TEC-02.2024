using Dtos;

namespace Domain;
public class Movie
{
    public string Title { get; set; }
    public string Director { get; set; }
    public DateTime ReleaseDate { get; set; }

    public Movie(string title, string director, DateTime releaseDate)
    {
        Title = title;
        Director = director;
        ReleaseDate = releaseDate;
    }
    public Movie(MovieDto movieDto)
    {
        Title = movieDto.Title;
        Director = movieDto.Director;
        ReleaseDate = movieDto.ReleaseDate;
    }

    public MovieDto ToMovieDto()
    {
        return new MovieDto(Title, Director, ReleaseDate);
    }

    public override string ToString()
    {
        return $"Title: {Title}, Director: {Director}, ReleaseDate: {ReleaseDate}";
    }
}
