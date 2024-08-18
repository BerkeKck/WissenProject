using System.Collections.Generic;

namespace eTickets.Models
{
    public class MovieViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CategoryName { get; set; }
        public List<string> ActorNames { get; set; }
    }
}
