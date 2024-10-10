using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.Models;

public class Movie
{
    public int Id { get; set; }
    
    [MaxLength(30)]
    public string Title { get; set; }
    public string Director { get; set; }
    public DateTime ReleaseDate { get; set; }

    public Movie(string title, string director, DateTime releaseDate)
    {
        Title = title;
        Director = director;
        ReleaseDate = releaseDate;
    }

    public override string ToString()
    {
        return $"Title: {Title}, Director: {Director}, ReleaseDate: {ReleaseDate}";
    }
}