using BusinessLogic.Models;

namespace BusinessLogic.DataAccess;

public class MemoryDB
{
    public List<Movie> Movies { get; set; }

    public MemoryDB()
    {
        Movies = new List<Movie>();
        loadDefaultMovies();
    }

    private void loadDefaultMovies()
    {
        Movies.Add(new Movie("El secreto de sus ojos", "Juan Jose Campanella", new DateTime(2009, 08, 13)));
    }
}