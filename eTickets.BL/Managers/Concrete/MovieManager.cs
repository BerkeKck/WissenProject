using eTickets.BL.Managers.Abstract;
using eTickets.Entities.DbContexts;
using eTickets.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTickets.BL.Managers.Concrete
{
    public class MovieManager : ManagerBase<Movie>, IMovieManager
    {
        private readonly AppDbContext _context;

        public MovieManager(AppDbContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<Movie> GetMovieByIdAsync(int id)
        {

            var movie = await _context.Movies.Include(m => m.MovieActors).ThenInclude(ma => ma.Actor)
            .Include(m => m.MovieCategories)
               .ThenInclude(mc => mc.Category)
            .FirstOrDefaultAsync(m => m.Id == id);
            return movie;
        }
        public async Task<List<Movie>> GetAllMoviesWithActorsAsync()
        {
            return await _context.Movies
       .Include(m => m.MovieActors)
       .ThenInclude(ma => ma.Actor)
       .ToListAsync();
        }
        public async Task<List<Movie>> GetAllMoviesWithCategoriesAsync()
        {
            return await _context.Movies
       .Include(m => m.MovieCategories)
       .ThenInclude(ma => ma.Category)
       .ToListAsync();
        }

        public async Task<Movie> GetAllMoviesWithCategoriesAndActorsByIdAsync(int id)
        {
            return await _context.Movies
       .Include(m => m.MovieCategories)
       .ThenInclude(ma => ma.Category)
       .Include(m => m.MovieActors)
       .ThenInclude(ma => ma.Actor)
       .SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task DeleteAsync(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
                await _context.SaveChangesAsync();
            }
        }
    }
}
