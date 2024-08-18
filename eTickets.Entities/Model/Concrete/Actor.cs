using eTickets.Entities.Model.Abstract;

namespace eTickets.Entities.Model.Concrete
{
    public class Actor : BaseEntity
    {
        public string ActorName { get; set; }
        public string PhotoUrl { get; set; }
        public ICollection<MovieActor> MovieActors { get; set; }

    }
}
