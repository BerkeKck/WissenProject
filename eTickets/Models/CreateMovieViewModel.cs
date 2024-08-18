using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class CreateMovieViewModel
    {
        [Required]
        [Display(Name ="Movie Name")]
        public string MovieName { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public IFormFile PhotoUrl { get; set; }

        [Required]
        [Display(Name = "Duration")]
        public int Duration { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        public List<int> SelectedActorIds { get; set; } = new List<int>();

        [Required]
        public List<int> SelectedCategoryIds { get; set; } = new List<int>();
    }
}
