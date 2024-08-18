using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class CreateTicketViewModel
    {
        [Required]
        public string MovieName { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public string PhotoUrl { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        public List<string> Seats { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public string Saloon { get; set; }


    }
}
