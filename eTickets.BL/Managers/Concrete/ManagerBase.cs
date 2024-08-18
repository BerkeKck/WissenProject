using eTickets.BL.Managers.Abstract;
using eTickets.DAL.Concrete;
using eTickets.Entities.DbContexts;
using eTickets.Entities.Model.Abstract;

namespace eTickets.BL.Managers.Concrete
{
    public class ManagerBase<T>:Repository<T>, IManager<T> where T : BaseEntity
    {
        private AppDbContext context;
        public ManagerBase(AppDbContext context)
        {
            this.context = context;
        }
    }
}
