// Name: Peter Do
// Student ID: 9086580

using Microsoft.AspNetCore.Mvc;
using MoviesApp.Models;
using MoviesApp.Repository;

namespace MoviesApp.Controllers
{
    public class MovieController : Controller
    {

        IMovieRepository _movieRepository;
        public MovieController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        // TODO: After Repository implementation, this method must call repository.GetById(id)
        // TODO: Validate the id before searching.
        public IActionResult GetById(int id)
        {   
            if (id <= 0)
            {
                return BadRequest("Invalid movie ID.");
            }

            Movie Result = _movieRepository.GetById(id);

            if (Result == null)
            {
                return NotFound("Movie not found.");
            }

            return View("GetById", Result);
        }

        // TODO: After Repository implementation, this must call repository.GetAll()
        public IActionResult Index()
        {
            return View(_movieRepository.GetAll());
        }

        // TODO: Students must implement Add, Edit, Delete actions (GET + POST)
        // TODO: All CRUD actions must use the repository.

        // GET: Movie/Add
        public IActionResult Add()
        {
            return View();
        }

        // POST: Movie/Add
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _movieRepository.Add(movie);
                _movieRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movie/Edit/{id}
        public IActionResult Edit(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid movie ID.");
            }

            Movie movie = _movieRepository.GetById(id);
            if (movie == null)
            {
                return NotFound("Movie not found.");
            }
            return View(movie);
        }

        // POST: Movie/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Movie movie)
        {
            if (id != movie.Id)
            {
                return BadRequest("Movie ID mismatch.");
            }

            if (ModelState.IsValid)
            {
                _movieRepository.Update(movie);
                _movieRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movie/Delete/{id}
        public IActionResult Delete(int id) 
        {
            if (id <= 0)
            {
                return BadRequest("Invalid movie ID.");
            }

            Movie movie = _movieRepository.GetById(id);

            if (movie == null)
            {
                return NotFound("Movie not found.");
            }

            return View(movie);
        }

        // POST: Movie/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _movieRepository.Delete(id);
            _movieRepository.Save();
            return RedirectToAction(nameof(Index));
        }
    }
}
