using eTickets.Entities.Model.Abstract;

namespace eTickets.Entities.Model.Concrete
{
    public class MovieCategory : BaseEntity
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}