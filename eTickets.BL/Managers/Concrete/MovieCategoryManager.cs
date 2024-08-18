using eTickets.BL.Managers.Abstract;
using eTickets.Entities.DbContexts;
using eTickets.Entities.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTickets.BL.Managers.Concrete
{
    public class MovieCategoryManager : ManagerBase<MovieCategory>, IMovieCategoryManager
    {
        public MovieCategoryManager(AppDbContext context) : base(context)
        {
        }
    }
}
