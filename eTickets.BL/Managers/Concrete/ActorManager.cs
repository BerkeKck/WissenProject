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
    public class ActorManager : ManagerBase<Actor>, IActorManager
    {
        private readonly AppDbContext _context;

        public ActorManager(AppDbContext context) : base(context)
        {
        }
    }
}
