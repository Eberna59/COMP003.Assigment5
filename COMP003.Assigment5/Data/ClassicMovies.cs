using COMP003.Assigment5.Models;

namespace COMP003.Assigment5.Data
{
    public class ClassicMovies
    {
        public static List<Movie> Movies { get; } = new()
        {
            new Movie {Id =1, Title = "Friday", Rating = 9.8m, ReleaseDate = new DateTime(4, 28, 1995) },
            new Movie {Id =2, Title = "Next Friday", Rating = 9.9m, ReleaseDate = new DateTime(1, 12, 2000) },
            new Movie {Id =3, Title = "Friday After Next", Rating = 8.8m, ReleaseDate = new DateTime(11, 22, 2002) }
        };
    }
}
