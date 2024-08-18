using eTickets.Entities;
using eTickets.Entities.Model.Concrete;
using System.Collections.Generic;

namespace eTickets.ViewModels
{
    public class MovieDetailsViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Actor> Actors { get; set; }
    }
}
