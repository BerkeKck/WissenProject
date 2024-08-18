using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using eTickets.Entities.Model.Concrete;
using eTickets.Entities.EntityConfig.Abstract;

namespace eTickets.Entities.EntityConfig.Concrete
{
    public class MovieCategoryConfig : BaseConfig<MovieCategory>
    {
        public override void Configure(EntityTypeBuilder<MovieCategory> builder)
        {
            base.Configure(builder);
            builder.HasData(
                // Movie 1 (Barbie) - Categories 6 (Romance), 7 (Adventure), 12 (Animation)
                new MovieCategory { Id = 1, MovieId = 1, CategoryId = 6 },
                new MovieCategory { Id = 2, MovieId = 1, CategoryId = 7 },
                new MovieCategory { Id = 3, MovieId = 1, CategoryId = 12 },

                // Movie 2 (Oppenheimer) - Categories 2 (Drama), 20 (War)
                new MovieCategory { Id = 4, MovieId = 2, CategoryId = 2 },
                new MovieCategory { Id = 5, MovieId = 2, CategoryId = 20 },

                // Movie 3 (Teenage Mutant Ninja Turtles: Mutant Mayhem) - Categories 7 (Adventure), 12 (Animation)
                new MovieCategory { Id = 6, MovieId = 3, CategoryId = 7 },
                new MovieCategory { Id = 7, MovieId = 3, CategoryId = 12 },

                // Movie 4 (Haunted Mansion) - Categories 4 (Horror), 11 (Family)
                new MovieCategory { Id = 8, MovieId = 4, CategoryId = 4 },
                new MovieCategory { Id = 9, MovieId = 4, CategoryId = 11 },

                // Movie 5 (Blue Beetle) - Categories 1 (Action), 5 (Sci-Fi)
                new MovieCategory { Id = 10, MovieId = 5, CategoryId = 1 },
                new MovieCategory { Id = 11, MovieId = 5, CategoryId = 5 },

                // Movie 6 (The Last Voyage of the Demeter) - Categories 4 (Horror), 19 (Psychological)
                new MovieCategory { Id = 12, MovieId = 6, CategoryId = 4 },
                new MovieCategory { Id = 13, MovieId = 6, CategoryId = 19 },

                // Movie 7 (Meg 2: The Trench) - Categories 1 (Action), 5 (Sci-Fi)
                new MovieCategory { Id = 14, MovieId = 7, CategoryId = 1 },
                new MovieCategory { Id = 15, MovieId = 7, CategoryId = 5 },

                // Movie 8 (Gran Turismo) - Categories 1 (Action), 7 (Adventure)
                new MovieCategory { Id = 16, MovieId = 8, CategoryId = 1 },
                new MovieCategory { Id = 17, MovieId = 8, CategoryId = 7 },

                // Movie 9 (Strays) - Categories 3 (Comedy)
                new MovieCategory { Id = 18, MovieId = 9, CategoryId = 3 },

                // Movie 10 (The Nun II) - Categories 4 (Horror)
                new MovieCategory { Id = 19, MovieId = 10, CategoryId = 4 },

                // Movie 11 (The Equalizer 3) - Categories 1 (Action), 9 (Thriller)
                new MovieCategory { Id = 20, MovieId = 11, CategoryId = 1 },
                new MovieCategory { Id = 21, MovieId = 11, CategoryId = 9 },

                // Movie 12 (It Lives Inside) - Categories 4 (Horror), 15 (Mystery)
                new MovieCategory { Id = 22, MovieId = 12, CategoryId = 4 },
                new MovieCategory { Id = 23, MovieId = 12, CategoryId = 15 },

                // Movie 13 (The Exorcist: Believer) - Categories 4 (Horror)
                new MovieCategory { Id = 24, MovieId = 13, CategoryId = 4 },

                // Movie 14 (Dumb Money) - Categories 2 (Drama), 18 (Crime)
                new MovieCategory { Id = 25, MovieId = 14, CategoryId = 2 },
                new MovieCategory { Id = 26, MovieId = 14, CategoryId = 18 },

                // Movie 15 (Paw Patrol: The Mighty Movie) - Categories 11 (Family), 12 (Animation)
                new MovieCategory { Id = 27, MovieId = 15, CategoryId = 11 },
                new MovieCategory { Id = 28, MovieId = 15, CategoryId = 12 },

                // Movie 16 (Saw X) - Categories 4 (Horror), 19 (Psychological)
                new MovieCategory { Id = 29, MovieId = 16, CategoryId = 4 },
                new MovieCategory { Id = 30, MovieId = 16, CategoryId = 19 },

                // Movie 17 (The Marvels) - Categories 1 (Action), 5 (Sci-Fi)
                new MovieCategory { Id = 31, MovieId = 17, CategoryId = 1 },
                new MovieCategory { Id = 32, MovieId = 17, CategoryId = 5 },

                // Movie 18 (Killers of the Flower Moon) - Categories 2 (Drama), 20 (Historical)
                new MovieCategory { Id = 33, MovieId = 18, CategoryId = 2 },
                new MovieCategory { Id = 34, MovieId = 18, CategoryId = 20 },

                // Movie 19 (Five Nights at Freddy’s) - Categories 4 (Horror)
                new MovieCategory { Id = 35, MovieId = 19, CategoryId = 4 },

                // Movie 20 (Napoleon) - Categories 20 (Historical)
                new MovieCategory { Id = 36, MovieId = 20, CategoryId = 20 },

                // Movie 21 (Reagan) - Categories 2 (Drama), 20 (Historical)
                new MovieCategory { Id = 37, MovieId = 21, CategoryId = 2 },
                new MovieCategory { Id = 38, MovieId = 21, CategoryId = 20 },

                // Movie 22 (Sing Sing) - Categories 17 (Musical), 11 (Family)
                new MovieCategory { Id = 39, MovieId = 22, CategoryId = 17 },
                new MovieCategory { Id = 40, MovieId = 22, CategoryId = 11 },

                // Movie 23 (War Game) - Categories 9 (Thriller), 20 (War)
                new MovieCategory { Id = 41, MovieId = 23, CategoryId = 9 },
                new MovieCategory { Id = 42, MovieId = 23, CategoryId = 20 },

                // Movie 24 (Saving Bikini Bottom: The Sandy Cheeks Movie) - Categories 11 (Family), 12 (Animation)
                new MovieCategory { Id = 43, MovieId = 24, CategoryId = 11 },
                new MovieCategory { Id = 44, MovieId = 24, CategoryId = 12 },

                // Movie 25 (Coup!) - Categories 9 (Thriller), 18 (Crime)
                new MovieCategory { Id = 45, MovieId = 25, CategoryId = 9 },
                new MovieCategory { Id = 46, MovieId = 25, CategoryId = 18 },

                // Movie 26 (Dark Feathers: Dance Of The Geisha) - Categories 15 (Mystery), 7 (Adventure)
                new MovieCategory { Id = 47, MovieId = 26, CategoryId = 15 },
                new MovieCategory { Id = 48, MovieId = 26, CategoryId = 7 },

                // Movie 27 (Rob Peace) - Categories 2 (Drama)
                new MovieCategory { Id = 49, MovieId = 27, CategoryId = 2 },

                // Movie 28 (Despicable Me 4) - Categories 12 (Animation), 3 (Comedy)
                new MovieCategory { Id = 50, MovieId = 28, CategoryId = 12 },
                new MovieCategory { Id = 51, MovieId = 28, CategoryId = 3 },

                // Movie 29 (Valleyheart) - Categories 6 (Romance)
                new MovieCategory { Id = 52, MovieId = 29, CategoryId = 6 },

                // Movie 30 (One Fast Move) - Categories 1 (Action)
                new MovieCategory { Id = 53, MovieId = 30, CategoryId = 1 },

                // Movie 31 (Cuckoo) - Categories 9 (Thriller), 19 (Psychological)
                new MovieCategory { Id = 54, MovieId = 31, CategoryId = 9 },
                new MovieCategory { Id = 55, MovieId = 31, CategoryId = 19 },

                // Movie 32 (It Ends With Us) - Categories 6 (Romance), 2 (Drama)
                new MovieCategory { Id = 56, MovieId = 32, CategoryId = 6 },
                new MovieCategory { Id = 57, MovieId = 32, CategoryId = 2 },

                // Movie 33 (Alien: Romulus) - Categories 5 (Sci-Fi), 4 (Horror)
                new MovieCategory { Id = 58, MovieId = 33, CategoryId = 5 },
                new MovieCategory { Id = 59, MovieId = 33, CategoryId = 4 },

                // Movie 34 (Close To You) - Categories 6 (Romance)
                new MovieCategory { Id = 60, MovieId = 34, CategoryId = 6 },

                // Movie 35 (The Crow) - Categories 4 (Horror), 9 (Thriller)
                new MovieCategory { Id = 61, MovieId = 35, CategoryId = 4 },
                new MovieCategory { Id = 62, MovieId = 35, CategoryId = 9 },

                // Movie 36 (Blink Twice) - Categories 15 (Mystery), 9 (Thriller)
                new MovieCategory { Id = 63, MovieId = 36, CategoryId = 15 },
                new MovieCategory { Id = 64, MovieId = 36, CategoryId = 9 },

                // Movie 37 (You Gotta Believe) - Categories 2 (Drama)
                new MovieCategory { Id = 65, MovieId = 37, CategoryId = 2 },

                // Movie 38 (The Retirement Plan) - Categories 9 (Thriller), 1 (Action)
                new MovieCategory { Id = 66, MovieId = 38, CategoryId = 9 },
                new MovieCategory { Id = 67, MovieId = 38, CategoryId = 1 },

                // Movie 39 (A Haunting in Venice) - Categories 4 (Horror), 15 (Mystery)
                new MovieCategory { Id = 68, MovieId = 39, CategoryId = 4 },
                new MovieCategory { Id = 69, MovieId = 39, CategoryId = 15 },

                // Movie 40 (Love at First Sight) - Categories 6 (Romance), 2 (Drama)
                new MovieCategory { Id = 70, MovieId = 40, CategoryId = 6 },
                new MovieCategory { Id = 71, MovieId = 40, CategoryId = 2 }

                );

        }
    }
}

