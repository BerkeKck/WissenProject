using eTickets.Entities.Model.Abstract;

namespace eTickets.Entities.Model.Concrete
{
    public class Movie : BaseEntity
    {
        public string MovieName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string PhotoUrl { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }

        //Çoka çok
        public ICollection<MovieActor> MovieActors { get; set; }
        public ICollection<MovieCategory> MovieCategories { get; set; }

        //public Category Category { get; set; }
        //public ICollection<Actor> Actors { get; set; } = new List<Actor>();
    }
}
