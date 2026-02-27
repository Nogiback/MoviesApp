using MoviesApp.Models;
using MoviesApp.Data;

namespace MoviesApp.Repository
{
    public class MovieRepository : IMovieRepository
    {
        public MovieDbContext Context { get; }

        public MovieRepository(MovieDbContext context)
        {
            Context = context;
        }
        public void Add(Movie obj)
        {
            Context.Movies.Add(obj);
        }

        public void Delete(int id)
        {
            var movie = Context.Movies.Find(id);
            if (movie != null)
            {
                Context.Movies.Remove(movie);
            }
        }

         public void Update(Movie obj)
        {
            Context.Movies.Update(obj);
        }

        public List<Movie> GetAll()
        {
            return Context.Movies.ToList();
        }

        public Movie GetById(int id)
        {
            return Context.Movies.Find(id);
        }

        public void Save()
        {
            Context.SaveChanges();
        }
    }
}