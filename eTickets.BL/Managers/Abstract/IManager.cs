using eTickets.DAL.Abstract;
using eTickets.Entities.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTickets.BL.Managers.Abstract
{
    public interface IManager<T> : IRepository<T> where T : BaseEntity
    {
     

    }
}
