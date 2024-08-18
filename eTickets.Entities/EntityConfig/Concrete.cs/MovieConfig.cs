using eTickets.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eTickets.Entities.EntityConfig.Concrete
{
    public class MovieConfig : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.MovieName).IsRequired().HasMaxLength(100);

            builder.HasData(
                 new Movie
                 {
                     Id = 1,
                     MovieName = "Barbie",
                     ReleaseDate = new DateTime(2024, 7, 21),
                     PhotoUrl = "barbie.jpg",
                     Duration = 114,
                     Description = "In a vibrant and colorful world, Barbie sets off on a journey of self-discovery and adventure."
                 },
                 new Movie
                 {
                     Id = 2,
                     MovieName = "Oppenheimer",
                     ReleaseDate = new DateTime(2024, 7, 21),
                     PhotoUrl = "oppenheimer.jpg",
                     Duration = 180,
                     Description = "A gripping biographical drama about J. Robert Oppenheimer and the development of the atomic bomb."
                 },
                 new Movie
                 {
                     Id = 3,
                     MovieName = "Teenage Mutant Ninja Turtles: Mutant Mayhem",
                     ReleaseDate = new DateTime(2024, 8, 2),
                     PhotoUrl = "tmnt_mutant_mayhem.jpg",
                     Duration = 99,
                     Description = "The Teenage Mutant Ninja Turtles return in an all-new animated adventure."
                 },
                 new Movie
                 {
                     Id = 4,
                     MovieName = "Haunted Mansion",
                     ReleaseDate = new DateTime(2024, 8, 11),
                     PhotoUrl = "haunted_mansion.jpg",
                     Duration = 123,
                     Description = "A single mother and her son enlist the help of a diverse group of experts to rid their home of supernatural inhabitants."
                 },
                 new Movie
                 {
                     Id = 5,
                     MovieName = "Blue Beetle",
                     ReleaseDate = new DateTime(2024, 8, 18),
                     PhotoUrl = "blue_beetle.jpg",
                     Duration = 127,
                     Description = "A young man becomes the Blue Beetle, a superhero powered by an alien scarab that grants him incredible abilities."
                 },
                 new Movie
                 {
                     Id = 6,
                     MovieName = "The Last Voyage of the Demeter",
                     ReleaseDate = new DateTime(2024, 8, 11),
                     PhotoUrl = "demeter.jpg",
                     Duration = 118,
                     Description = "A chilling horror tale based on the story of the ship that brought Dracula to England."
                 },
                 new Movie
                 {
                     Id = 7,
                     MovieName = "Meg 2: The Trench",
                     ReleaseDate = new DateTime(2024, 8, 4),
                     PhotoUrl = "meg_2.jpg",
                     Duration = 116,
                     Description = "A deep-sea thriller where a team of explorers must face a new and terrifying underwater threat."
                 },
                 new Movie
                 {
                     Id = 8,
                     MovieName = "Gran Turismo",
                     ReleaseDate = new DateTime(2024, 8, 18),
                     PhotoUrl = "gran_turismo.jpg",
                     Duration = 135,
                     Description = "Based on the true story of a gamer who becomes a professional race car driver through the Gran Turismo gaming franchise."
                 },
                 new Movie
                 {
                     Id = 9,
                     MovieName = "Strays",
                     ReleaseDate = new DateTime(2024, 8, 11),
                     PhotoUrl = "strays.jpg",
                     Duration = 93,
                     Description = "A raunchy comedy where a group of stray dogs team up to get revenge on their owners."
                 },
                 new Movie
                 {
                     Id = 10,
                     MovieName = "The Nun II",
                     ReleaseDate = new DateTime(2024, 9, 8),
                     PhotoUrl = "nun_2.jpg",
                     Duration = 110,
                     Description = "The demonic nun returns to terrorize a new group of unsuspecting victims."
                 },
                 new Movie
                 {
                     Id = 11,
                     MovieName = "The Equalizer 3",
                     ReleaseDate = new DateTime(2024, 9, 1),
                     PhotoUrl = "equalizer_3.jpg",
                     Duration = 108,
                     Description = "Robert McCall returns to dispense justice in his own unique way."
                 },
                 new Movie
                 {
                     Id = 12,
                     MovieName = "It Lives Inside",
                     ReleaseDate = new DateTime(2024, 9, 15),
                     PhotoUrl = "it_lives_inside.jpg",
                     Duration = 95,
                     Description = "A horror film about a young girl who must confront a malevolent entity from her culture's folklore."
                 },
                 new Movie
                 {
                     Id = 13,
                     MovieName = "The Exorcist: Believer",
                     ReleaseDate = new DateTime(2024, 10, 13),
                     PhotoUrl = "exorcist_believer.jpg",
                     Duration = 120,
                     Description = "A continuation of the iconic Exorcist saga, exploring new cases of possession."
                 },
                 new Movie
                 {
                     Id = 14,
                     MovieName = "Dumb Money",
                     ReleaseDate = new DateTime(2024, 10, 6),
                     PhotoUrl = "dumb_money.jpg",
                     Duration = 104,
                     Description = "A comedic drama based on the true story of the GameStop stock phenomenon."
                 },
                 new Movie
                 {
                     Id = 15,
                     MovieName = "Paw Patrol: The Mighty Movie",
                     ReleaseDate = new DateTime(2024, 10, 20),
                     PhotoUrl = "paw_patrol.jpg",
                     Duration = 88,
                     Description = "The Paw Patrol pups return in an action-packed adventure where they gain new superpowers."
                 },
                 new Movie
                 {
                     Id = 16,
                     MovieName = "Saw X",
                     ReleaseDate = new DateTime(2024, 10, 27),
                     PhotoUrl = "saw_x.jpg",
                     Duration = 105,
                     Description = "The iconic horror franchise returns with another mind-bending chapter of traps and terror."
                 },
                 new Movie
                 {
                     Id = 17,
                     MovieName = "The Marvels",
                     ReleaseDate = new DateTime(2024, 11, 10),
                     PhotoUrl = "the_marvels.jpg",
                     Duration = 124,
                     Description = "Captain Marvel teams up with Ms. Marvel and Monica Rambeau to face a new cosmic threat."
                 },
                 new Movie
                 {
                     Id = 18,
                     MovieName = "Killers of the Flower Moon",
                     ReleaseDate = new DateTime(2024, 11, 17),
                     PhotoUrl = "killers_of_the_flower_moon.jpg",
                     Duration = 206,
                     Description = "A true-crime drama about the Osage murders and the birth of the FBI."
                 },
                 new Movie
                 {
                     Id = 19,
                     MovieName = "Five Nights at Freddy’s",
                     ReleaseDate = new DateTime(2024, 10, 27),
                     PhotoUrl = "five_nights_at_freddys.jpg",
                     Duration = 102,
                     Description = "A horror film adaptation of the popular video game series where animatronics come to life with deadly intent."
                 },
                 new Movie
                 {
                     Id = 20,
                     MovieName = "Napoleon",
                     ReleaseDate = new DateTime(2024, 11, 22),
                     PhotoUrl = "napoleon.jpg",
                     Duration = 157,
                     Description = "A historical epic that chronicles the rise and fall of Napoleon Bonaparte."
                 },
                 new Movie
                 {
                     Id = 21,
                     MovieName = "Reagan",
                     ReleaseDate = new DateTime(2024, 11, 15),
                     PhotoUrl = "reagan.jpg",
                     Duration = 98,
                     Description = "A biographical film about Ronald Reagan's journey from Hollywood actor to the President of the United States."
                 },
                 new Movie
                 {
                     Id = 22,
                     MovieName = "Sing Sing",
                     ReleaseDate = new DateTime(2024, 12, 1),
                     PhotoUrl = "sing_sing.jpg",
                     Duration = 96,
                     Description = "A musical drama set in a prison where inmates find redemption through song and dance."
                 },
                 new Movie
                 {
                     Id = 23,
                     MovieName = "War Game",
                     ReleaseDate = new DateTime(2024, 12, 8),
                     PhotoUrl = "war_game.jpg",
                     Duration = 101,
                     Description = "A suspenseful war thriller where soldiers must navigate deadly mind games in a high-stakes battle."
                 },
                 new Movie
                 {
                     Id = 24,
                     MovieName = "Saving Bikini Bottom: The Sandy Cheeks Movie",
                     ReleaseDate = new DateTime(2024, 12, 15),
                     PhotoUrl = "sandy_cheeks.jpg",
                     Duration = 90,
                     Description = "Sandy Cheeks leads a mission to save Bikini Bottom from an environmental disaster."
                 },
                 new Movie
                 {
                     Id = 25,
                     MovieName = "Coup!",
                     ReleaseDate = new DateTime(2024, 12, 22),
                     PhotoUrl = "coup.jpg",
                     Duration = 112,
                     Description = "A political thriller about a journalist who uncovers a plot to overthrow a government."
                 },
                 new Movie
                 {
                     Id = 26,
                     MovieName = "Dark Feathers: Dance Of The Geisha",
                     ReleaseDate = new DateTime(2024, 12, 10),
                     PhotoUrl = "dark_feathers.jpg",
                     Duration = 115,
                     Description = "A captivating story that combines the mystery of dark feathers with the elegance of a geisha dance."
                 },
                new Movie
                {
                    Id = 27,
                    MovieName = "Rob Peace",
                    ReleaseDate = new DateTime(2024, 12, 12),
                    PhotoUrl = "rob_peace.jpg",
                    Duration = 130,
                    Description = "A drama that follows the life of Rob Peace, exploring themes of struggle and redemption."
                },
                new Movie
                {
                    Id = 28,
                    MovieName = "Despicable Me 4",
                    ReleaseDate = new DateTime(2024, 12, 20),
                    PhotoUrl = "despicable_me_4.jpg",
                    Duration = 90,
                    Description = "The minions are back for more mischief and adventure in the latest installment of the Despicable Me series."
                },
                new Movie
                {
                    Id = 29,
                    MovieName = "Valleyheart",
                    ReleaseDate = new DateTime(2024, 12, 25),
                    PhotoUrl = "valleyheart.jpg",
                    Duration = 108,
                    Description = "A heartwarming tale set in a picturesque valley, focusing on personal growth and romance."
                },
                new Movie
                {
                    Id = 30,
                    MovieName = "One Fast Move",
                    ReleaseDate = new DateTime(2024, 12, 28),
                    PhotoUrl = "one_fast_move.jpg",
                    Duration = 100,
                    Description = "A high-octane action film featuring a race against time and relentless pursuit."
                },
                new Movie
                {
                    Id = 31,
                    MovieName = "Cuckoo",
                    ReleaseDate = new DateTime(2024, 12, 30),
                    PhotoUrl = "cuckoo.jpg",
                    Duration = 105,
                    Description = "A psychological thriller that delves into the mind of a man with an unsettling obsession."
                },
                new Movie
                {
                    Id = 32,
                    MovieName = "It Ends With Us",
                    ReleaseDate = new DateTime(2024, 12, 15),
                    PhotoUrl = "it_ends_with_us.jpg",
                    Duration = 120,
                    Description = "A dramatic love story that explores the impact of a toxic relationship and personal growth."
                },
                new Movie
                {
                    Id = 33,
                    MovieName = "Alien: Romulus",
                    ReleaseDate = new DateTime(2024, 12, 22),
                    PhotoUrl = "alien_romulus.jpg",
                    Duration = 125,
                    Description = "The latest entry in the Alien franchise, focusing on a new planet and fresh horrors."
                },
                new Movie
                {
                    Id = 34,
                    MovieName = "Close To You",
                    ReleaseDate = new DateTime(2024, 12, 18),
                    PhotoUrl = "close_to_you.jpg",
                    Duration = 110,
                    Description = "A touching romance that explores the complexities of love and relationships."
                },
                new Movie
                {
                    Id = 35,
                    MovieName = "The Crow",
                    ReleaseDate = new DateTime(2024, 12, 24),
                    PhotoUrl = "the_crow.jpg",
                    Duration = 98,
                    Description = "A dark and atmospheric film about revenge and redemption, inspired by the classic tale."
                },
                new Movie
                {
                    Id = 36,
                    MovieName = "Blink Twice",
                    ReleaseDate = new DateTime(2024, 12, 26),
                    PhotoUrl = "blink_twice.jpg",
                    Duration = 102,
                    Description = "A suspenseful thriller where every blink might reveal a hidden truth."
                },
                new Movie
                {
                    Id = 37,
                    MovieName = "You Gotta Believe",
                    ReleaseDate = new DateTime(2024, 12, 28),
                    PhotoUrl = "you_gotta_believe.jpg",
                    Duration = 116,
                    Description = "An inspiring story of faith and perseverance in the face of overwhelming odds."
                },
                new Movie
                {
                    Id = 38,
                    MovieName = "The Retirement Plan",
                    ReleaseDate = new DateTime(2024, 12, 30),
                    PhotoUrl = "retirement_plan.jpg",
                    Duration = 125,
                    Description = "A comedic and heartfelt look at the life of a retiree who finds unexpected adventure."
                },
                new Movie
                {
                    Id = 39,
                    MovieName = "A Haunting in Venice",
                    ReleaseDate = new DateTime(2024, 12, 29),
                    PhotoUrl = "haunting_venice.jpg",
                    Duration = 120,
                    Description = "A chilling ghost story set in the picturesque city of Venice."
                },
                new Movie
                {
                    Id = 40,
                    MovieName = "Love at First Sight",
                    ReleaseDate = new DateTime(2024, 12, 31),
                    PhotoUrl = "love_at_first_sight.jpg",
                    Duration = 105,
                    Description = "A romantic comedy about the magic of falling in love unexpectedly."
                }
           );
        }
    }
}
