using System.ComponentModel.DataAnnotations;
namespace eTickets.Models 
{ 
    public class EditMovieViewModel
    {
        public int Id { get; set; }
        public string? MovieName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string? PhotoUrl { get; set; }
        public IFormFile? NewPhotoUrl { get; set; }
        public double? Duration { get; set; }
        public string? Description { get; set; }
        public List<int> SelectedActorIds { get; set; } = new List<int>();
        public List<int> SelectedCategoryIds { get; set; } = new List<int>();

    }
}