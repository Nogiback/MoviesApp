using MoviesApp.Models;

namespace MoviesApp.Repository 
{
  public interface IMovieRepository
    {
      // CRUD operations for Movie
      void Add(Movie obj);

      void Delete(int id);

      void Update(Movie obj);

      void Save();

      Movie GetById(int id);

      List<Movie> GetAll();
      
    }
}