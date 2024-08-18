using eTickets.Entities.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTickets.BL.Managers.Abstract
{
    public interface IMovieManager:IManager<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<List<Movie>> GetAllMoviesWithActorsAsync();
        Task<List<Movie>> GetAllMoviesWithCategoriesAsync();
        Task<Movie> GetAllMoviesWithCategoriesAndActorsByIdAsync(int id);
        Task DeleteAsync(int id);

    }
}
