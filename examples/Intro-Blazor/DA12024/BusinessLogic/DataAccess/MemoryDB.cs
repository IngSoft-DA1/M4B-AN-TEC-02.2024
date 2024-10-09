using Domain;

namespace BusinessLogic.DataAccess;

public class MemoryDB
{
    public List<Movie> Movies { get; set; }
    public List<User> Users { get; set; }

    public MemoryDB()
    {
        Movies = new List<Movie>();
        loadDefaultMovies();
        Users = new List<User>();
        LoadDefaultUser();
    }

    private void loadDefaultMovies()
    {
        Movies.Add(new Movie("El secreto de sus ojos", "Juan Jose Campanella", new DateTime(2009, 08, 13)));
    }

    private void LoadDefaultUser()
    {
        Users.Add(new User("alumno@ort.edu.uy", "123456", "Administrator"));
    }
}