using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using eTickets.Entities.Model.Concrete;
using eTickets.Entities.EntityConfig.Abstract;

namespace eTickets.Entities.EntityConfig.Concrete
{
    public class MovieActorConfig : BaseConfig<MovieActor>
    {
        public override void Configure(EntityTypeBuilder<MovieActor> builder)
        {
            base.Configure(builder);
            builder.HasData(
                // Movie-Actor Relationships
                // Barbie - Margot Robbie, Ryan Gosling
                new MovieActor { Id = 1, MovieId = 1, ActorId = 35 },
                new MovieActor { Id = 2, MovieId = 1, ActorId = 36 },

    
                // Oppenheimer filmine ait oyuncular
                new MovieActor { Id = 4, MovieId = 2, ActorId = 48 }, // Emily Blunt
                new MovieActor { Id = 5, MovieId = 2, ActorId = 1 },  // Robert Downey Jr.
                new MovieActor { Id = 6, MovieId = 2, ActorId = 23 }, // Matt Damon


                // Teenage Mutant Ninja Turtles: Mutant Mayhem - Zendaya
                new MovieActor { Id = 8, MovieId = 3, ActorId = 31 },// Zendaya
                new MovieActor { Id = 9, MovieId = 3, ActorId = 69 },
                   
                 //Haunted Mansion
                new MovieActor { Id = 10, MovieId = 4, ActorId = 55 },//Jared Leto

                //Haunted Blue Beetle
                new MovieActor { Id = 11, MovieId = 5, ActorId = 60 },//Xolo Maridueña

                //The Last Voyage of the Demeter
                new MovieActor { Id = 12, MovieId = 6, ActorId = 61 },//LiamCunningham

                //Meg 2: The Trench
                new MovieActor { Id = 13, MovieId = 7, ActorId = 62 },//jason statham

                //Gran Turismo
                new MovieActor { Id = 14, MovieId = 8, ActorId = 63 },//Orlando bloom
                
                //Strays
                new MovieActor { Id = 15, MovieId = 9, ActorId = 64 },//Mark Wahlberg

                //The Nun II
                new MovieActor { Id = 16, MovieId = 10, ActorId = 65 }//Storm Reid

             );
        }
    }
}

