using COMP003.Assigment5.Models;
using COMP003.Assigment5.Data;
using Microsoft.AspNetCore.Mvc;

namespace COMP003.Assigment5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : Controller
    {
        [HttpGet]
        public ActionResult<List<Movie>> GetMovies()
        {
            return Ok(MovieStore.Movies);
        }

        [HttpGet("{id}")]
        public ActionResult<Movie> GetMovie(int id)
        {
            var movie = MovieStore.Movies.FirstOrDefault(x => x.Id == id);

            if (movie is null)
                return NotFound();

            return Ok(movie);
        }

        [HttpPost]
        public ActionResult<Movie> CreateMovie(Movie movie)
        {
            movie.Id = MovieStore.Movies.Max(x => x.Id) + 1;
            MovieStore.Movies.Add(movie);

            return CreatedAtAction(nameof(GetMovie), new { id = movie.Id }, movie);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMovie(int id, Movie updatedMovie)
        {
            if (id != updatedMovie.Id)
                return BadRequest();

            var existingMovie = MovieStore.Movies.FirstOrDefault(x => x.Id == id);
            if (existingMovie is null)
                return NotFound();

            existingMovie.Title = updatedMovie.Title;
            existingMovie.Rating = updatedMovie.Rating;
            existingMovie.ReleaseDate = updatedMovie.ReleaseDate;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMovie(int id)
        {
            var movie = MovieStore.Movies.FirstOrDefault(x => x.Id == id);

            if (movie is null)
                return NotFound();

            MovieStore.Movies.Remove(movie);

            return NoContent();
        }
    }
}
