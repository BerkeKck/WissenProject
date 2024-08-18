using eTickets.Entities.Model.Abstract;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Entities.Model.Concrete
{
    public class MovieActor : BaseEntity
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
