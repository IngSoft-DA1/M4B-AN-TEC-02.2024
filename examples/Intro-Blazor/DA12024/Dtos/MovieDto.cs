using Domain;

namespace Dtos
{
    public class MovieDto
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public DateTime ReleaseDate { get; set; }

        public Movie ToEntity()
        {
            return new Movie(Title, Director, ReleaseDate)
            {
                Title = Title,
                Director = Director,
                ReleaseDate = ReleaseDate,
            };
        }

        public static MovieDto FromEntity(Movie movie)
        {
            return new MovieDto()
            {
                Title = movie.Title,
                Director = movie.Director,
                ReleaseDate = movie.ReleaseDate,
            };
        }
    }
}
