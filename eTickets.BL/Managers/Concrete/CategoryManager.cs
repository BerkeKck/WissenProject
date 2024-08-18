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
    public class CategoryManager : ManagerBase<Category>, ICategoryManager
    {
        public CategoryManager(AppDbContext context) : base(context)
        {
        }
    }
}

