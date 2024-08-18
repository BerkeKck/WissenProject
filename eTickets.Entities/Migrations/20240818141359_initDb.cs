using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eTickets.Entities.Migrations
{
    /// <inheritdoc />
    public partial class initDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ActorName = table.Column<string>(type: "longtext", nullable: false),
                    PhotoUrl = table.Column<string>(type: "longtext", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(type: "longtext", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MovieName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PhotoUrl = table.Column<string>(type: "longtext", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MovieActors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieActors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieActors_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieActors_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MovieCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieCategories_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "ActorName", "CreateDate", "PhotoUrl" },
                values: new object[,]
                {
                    { 1, "Robert Downey Jr.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RobertDowneyJr.jpg" },
                    { 2, "Chris Evans", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ChrisEvans.jpg" },
                    { 3, "Scarlett Johansson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ScarlettJohansson.jpg" },
                    { 4, "Leonardo DiCaprio", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LeonardoDiCaprio.jpg" },
                    { 5, "Tom Hanks", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TomHanks.jpg" },
                    { 6, "Brad Pitt", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BradPitt.jpg" },
                    { 7, "Johnny Depp", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "JohnnyDepp.jpg" },
                    { 8, "Denzel Washington", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DenzelWashington.jpg" },
                    { 9, "Meryl Streep", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MerylStreep.jpg" },
                    { 10, "Morgan Freeman", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MorganFreeman.jpg" },
                    { 11, "Tom Cruise", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TomCruise.jpg" },
                    { 12, "Jennifer Lawrence", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "JenniferLawrence.jpg" },
                    { 13, "Will Smith", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WillSmith.jpg" },
                    { 14, "Christian Bale", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ChristianBale.jpg" },
                    { 15, "Natalie Portman", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NataliePortman.jpg" },
                    { 16, "Hugh Jackman", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HughJackman.jpg" },
                    { 17, "Emma Watson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EmmaWatson.jpg" },
                    { 18, "Matthew McConaughey", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MatthewMcConaughey.jpg" },
                    { 19, "Angelina Jolie", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AngelinaJolie.jpg" },
                    { 20, "Ryan Reynolds", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RyanReynolds.jpg" },
                    { 21, "George Clooney", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GeorgeClooney.jpg" },
                    { 22, "Julia Roberts", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "JuliaRoberts.jpg" },
                    { 23, "Matt Damon", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MattDamon.jpg" },
                    { 24, "Keanu Reeves", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KeanuReeves.jpg" },
                    { 25, "Charlize Theron", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CharlizeTheron.jpg" },
                    { 26, "Anne Hathaway", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AnneHathaway.jpg" },
                    { 27, "Harrison Ford", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HarrisonFord.jpg" },
                    { 28, "Chris Hemsworth", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ChrisHemsworth.jpg" },
                    { 29, "Robert De Niro", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RobertDeNiro.jpg" },
                    { 30, "Al Pacino", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AlPacino.jpg" },
                    { 31, "Zendaya", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zendaya.jpg" },
                    { 32, "Timothée Chalamet", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TimothéeChalamet.jpg" },
                    { 33, "Tom Holland", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TomHolland.jpg" },
                    { 34, "Emma Stone", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EmmaStone.jpg" },
                    { 35, "Margot Robbie", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MargotRobbie.jpg" },
                    { 36, "Ryan Gosling", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RyanGosling.jpg" },
                    { 37, "Daisy Ridley", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DaisyRidley.jpg" },
                    { 38, "Adam Driver", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AdamDriver.jpg" },
                    { 39, "John Boyega", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "JohnBoyega.jpg" },
                    { 40, "Oscar Isaac", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OscarIsaac.jpg" },
                    { 41, "Benedict Cumberbatch", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BenedictCumberbatch.jpg" },
                    { 42, "Rami Malek", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RamiMalek.jpg" },
                    { 43, "Jason Momoa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "JasonMomoa.jpg" },
                    { 44, "Zac Efron", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ZacEfron.jpg" },
                    { 45, "Shailene Woodley", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShaileneWoodley.jpg" },
                    { 46, "Idris Elba", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IdrisElba.jpg" },
                    { 47, "Rebecca Ferguson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RebeccaFerguson.jpg" },
                    { 48, "Emily Blunt", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EmilyBlunt.jpg" },
                    { 49, "Paul Rudd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PaulRudd.jpg" },
                    { 50, "Mila Kunis", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MilaKunis.jpg" },
                    { 51, "Gal Gadot", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GalGadot.jpg" },
                    { 52, "Anya Taylor-Joy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AnyaTaylorJoy.jpg" },
                    { 53, "Michael Fassbender", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MichaelFassbender.jpg" },
                    { 54, "Tessa Thompson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TessaThompson.jpg" },
                    { 55, "Jared Leto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "JaredLeto.jpg" },
                    { 56, "Eiza González", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EizaGonzález.jpg" },
                    { 57, "Elizabeth Debicki", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ElizabethDebicki.jpg" },
                    { 58, "Tom Hardy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TomHardy.jpg" },
                    { 59, "Mads Mikkelsen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MadsMikkelsen.jpg" },
                    { 60, "Xolo Mariduena", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "XoloMariduena.jpg" },
                    { 61, "Liam Cunningham", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LiamCunningham.jpg" },
                    { 62, "Jason Statham", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "JasonStatham.jpg" },
                    { 63, "Orlando Bloom", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OrlandoBloom.jpg" },
                    { 64, "Mark Wahlberg ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MarkWahlberg.jpg" },
                    { 65, "Storm Reid", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "StormReid.jpg" },
                    { 66, "Megan Suri", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MeganSuri.jpg" },
                    { 67, "Leslie Odom Jr.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LeslieOdomJr.jpg" },
                    { 68, "Pete Davidson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PeteDavidson.jpg" },
                    { 69, "John Cena", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "JohnCena.jpg" },
                    { 70, "Kristen Bell", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KristenBell.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreateDate" },
                values: new object[,]
                {
                    { 1, "Action", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Drama", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Comedy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Horror", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Sci-Fi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Romance", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Adventure", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Fantasy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Thriller", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "Documentary", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "Family", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "Animation", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "Blu Ray", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "Cartoons", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "Mystery", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, "Indian", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, "Musical", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, "Crime", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, "Psychological", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, "War", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, "Historical", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CreateDate", "Description", "Duration", "MovieName", "PhotoUrl", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In a vibrant and colorful world, Barbie sets off on a journey of self-discovery and adventure.", 114, "Barbie", "barbie.jpg", new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A gripping biographical drama about J. Robert Oppenheimer and the development of the atomic bomb.", 180, "Oppenheimer", "oppenheimer.jpg", new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Teenage Mutant Ninja Turtles return in an all-new animated adventure.", 99, "Teenage Mutant Ninja Turtles: Mutant Mayhem", "tmnt_mutant_mayhem.jpg", new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A single mother and her son enlist the help of a diverse group of experts to rid their home of supernatural inhabitants.", 123, "Haunted Mansion", "haunted_mansion.jpg", new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A young man becomes the Blue Beetle, a superhero powered by an alien scarab that grants him incredible abilities.", 127, "Blue Beetle", "blue_beetle.jpg", new DateTime(2024, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A chilling horror tale based on the story of the ship that brought Dracula to England.", 118, "The Last Voyage of the Demeter", "demeter.jpg", new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A deep-sea thriller where a team of explorers must face a new and terrifying underwater threat.", 116, "Meg 2: The Trench", "meg_2.jpg", new DateTime(2024, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Based on the true story of a gamer who becomes a professional race car driver through the Gran Turismo gaming franchise.", 135, "Gran Turismo", "gran_turismo.jpg", new DateTime(2024, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A raunchy comedy where a group of stray dogs team up to get revenge on their owners.", 93, "Strays", "strays.jpg", new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The demonic nun returns to terrorize a new group of unsuspecting victims.", 110, "The Nun II", "nun_2.jpg", new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robert McCall returns to dispense justice in his own unique way.", 108, "The Equalizer 3", "equalizer_3.jpg", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A horror film about a young girl who must confront a malevolent entity from her culture's folklore.", 95, "It Lives Inside", "it_lives_inside.jpg", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A continuation of the iconic Exorcist saga, exploring new cases of possession.", 120, "The Exorcist: Believer", "exorcist_believer.jpg", new DateTime(2024, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A comedic drama based on the true story of the GameStop stock phenomenon.", 104, "Dumb Money", "dumb_money.jpg", new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Paw Patrol pups return in an action-packed adventure where they gain new superpowers.", 88, "Paw Patrol: The Mighty Movie", "paw_patrol.jpg", new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The iconic horror franchise returns with another mind-bending chapter of traps and terror.", 105, "Saw X", "saw_x.jpg", new DateTime(2024, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Captain Marvel teams up with Ms. Marvel and Monica Rambeau to face a new cosmic threat.", 124, "The Marvels", "the_marvels.jpg", new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A true-crime drama about the Osage murders and the birth of the FBI.", 206, "Killers of the Flower Moon", "killers_of_the_flower_moon.jpg", new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A horror film adaptation of the popular video game series where animatronics come to life with deadly intent.", 102, "Five Nights at Freddy’s", "five_nights_at_freddys.jpg", new DateTime(2024, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A historical epic that chronicles the rise and fall of Napoleon Bonaparte.", 157, "Napoleon", "napoleon.jpg", new DateTime(2024, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A biographical film about Ronald Reagan's journey from Hollywood actor to the President of the United States.", 98, "Reagan", "reagan.jpg", new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A musical drama set in a prison where inmates find redemption through song and dance.", 96, "Sing Sing", "sing_sing.jpg", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A suspenseful war thriller where soldiers must navigate deadly mind games in a high-stakes battle.", 101, "War Game", "war_game.jpg", new DateTime(2024, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sandy Cheeks leads a mission to save Bikini Bottom from an environmental disaster.", 90, "Saving Bikini Bottom: The Sandy Cheeks Movie", "sandy_cheeks.jpg", new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A political thriller about a journalist who uncovers a plot to overthrow a government.", 112, "Coup!", "coup.jpg", new DateTime(2024, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A captivating story that combines the mystery of dark feathers with the elegance of a geisha dance.", 115, "Dark Feathers: Dance Of The Geisha", "dark_feathers.jpg", new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A drama that follows the life of Rob Peace, exploring themes of struggle and redemption.", 130, "Rob Peace", "rob_peace.jpg", new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The minions are back for more mischief and adventure in the latest installment of the Despicable Me series.", 90, "Despicable Me 4", "despicable_me_4.jpg", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A heartwarming tale set in a picturesque valley, focusing on personal growth and romance.", 108, "Valleyheart", "valleyheart.jpg", new DateTime(2024, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A high-octane action film featuring a race against time and relentless pursuit.", 100, "One Fast Move", "one_fast_move.jpg", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A psychological thriller that delves into the mind of a man with an unsettling obsession.", 105, "Cuckoo", "cuckoo.jpg", new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A dramatic love story that explores the impact of a toxic relationship and personal growth.", 120, "It Ends With Us", "it_ends_with_us.jpg", new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The latest entry in the Alien franchise, focusing on a new planet and fresh horrors.", 125, "Alien: Romulus", "alien_romulus.jpg", new DateTime(2024, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A touching romance that explores the complexities of love and relationships.", 110, "Close To You", "close_to_you.jpg", new DateTime(2024, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A dark and atmospheric film about revenge and redemption, inspired by the classic tale.", 98, "The Crow", "the_crow.jpg", new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A suspenseful thriller where every blink might reveal a hidden truth.", 102, "Blink Twice", "blink_twice.jpg", new DateTime(2024, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An inspiring story of faith and perseverance in the face of overwhelming odds.", 116, "You Gotta Believe", "you_gotta_believe.jpg", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A comedic and heartfelt look at the life of a retiree who finds unexpected adventure.", 125, "The Retirement Plan", "retirement_plan.jpg", new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A chilling ghost story set in the picturesque city of Venice.", 120, "A Haunting in Venice", "haunting_venice.jpg", new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A romantic comedy about the magic of falling in love unexpectedly.", 105, "Love at First Sight", "love_at_first_sight.jpg", new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "MovieActors",
                columns: new[] { "Id", "ActorId", "CreateDate", "MovieId" },
                values: new object[,]
                {
                    { 1, 35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, 48, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 5, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 6, 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 8, 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 9, 69, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, 55, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 12, 61, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 13, 62, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 14, 63, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 15, 64, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 16, 65, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 }
                });

            migrationBuilder.InsertData(
                table: "MovieCategories",
                columns: new[] { "Id", "CategoryId", "CreateDate", "MovieId" },
                values: new object[,]
                {
                    { 1, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 5, 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 6, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 7, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 8, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 9, 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 11, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 12, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 13, 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 14, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 15, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 16, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 17, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 18, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 19, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 20, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 21, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 22, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 23, 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 24, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 25, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 26, 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 27, 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 28, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 29, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 30, 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 31, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 32, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 33, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 34, 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 35, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 36, 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 37, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 38, 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 39, 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 40, 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 41, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 42, 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 43, 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 44, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 45, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 46, 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 47, 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 48, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 49, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 50, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 51, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 52, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 53, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 54, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 },
                    { 55, 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 },
                    { 56, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 57, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 58, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33 },
                    { 59, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33 },
                    { 60, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 },
                    { 61, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 62, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 63, 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 },
                    { 64, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 },
                    { 65, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37 },
                    { 66, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 },
                    { 67, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 },
                    { 68, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 },
                    { 69, 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 },
                    { 70, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 },
                    { 71, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieActors_ActorId",
                table: "MovieActors",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieActors_MovieId",
                table: "MovieActors",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieCategories_CategoryId",
                table: "MovieCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieCategories_MovieId",
                table: "MovieCategories",
                column: "MovieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieActors");

            migrationBuilder.DropTable(
                name: "MovieCategories");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
