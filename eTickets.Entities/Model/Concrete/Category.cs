using eTickets.Entities.Model.Abstract;

namespace eTickets.Entities.Model.Concrete
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        //public ICollection<Movie> Movies { get; set; } = new List<Movie>();
        public ICollection<MovieCategory> MovieCategories { get; set; }

    }
}
