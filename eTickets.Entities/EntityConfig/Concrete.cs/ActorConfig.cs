using eTickets.Entities.Model.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using eTickets.Entities.EntityConfig.Abstract;
using System.Reflection.Emit;

public class ActorConfig : BaseConfig<Actor>
{
    public override void Configure(EntityTypeBuilder<Actor> builder)
    {
        base.Configure(builder);

        builder.HasData(
    new Actor { Id = 1, ActorName = "Robert Downey Jr.", PhotoUrl = "RobertDowneyJr.jpg" },
    new Actor { Id = 2, ActorName = "Chris Evans", PhotoUrl = "ChrisEvans.jpg" },
    new Actor { Id = 3, ActorName = "Scarlett Johansson", PhotoUrl = "ScarlettJohansson.jpg" },
    new Actor { Id = 4, ActorName = "Leonardo DiCaprio", PhotoUrl = "LeonardoDiCaprio.jpg" },
    new Actor { Id = 5, ActorName = "Tom Hanks", PhotoUrl = "TomHanks.jpg" },
    new Actor { Id = 6, ActorName = "Brad Pitt", PhotoUrl = "BradPitt.jpg" },
    new Actor { Id = 7, ActorName = "Johnny Depp", PhotoUrl = "JohnnyDepp.jpg" },
    new Actor { Id = 8, ActorName = "Denzel Washington", PhotoUrl = "DenzelWashington.jpg" },
    new Actor { Id = 9, ActorName = "Meryl Streep", PhotoUrl = "MerylStreep.jpg" },
    new Actor { Id = 10, ActorName = "Morgan Freeman", PhotoUrl = "MorganFreeman.jpg" },
    new Actor { Id = 11, ActorName = "Tom Cruise", PhotoUrl = "TomCruise.jpg" },
    new Actor { Id = 12, ActorName = "Jennifer Lawrence", PhotoUrl = "JenniferLawrence.jpg" },
    new Actor { Id = 13, ActorName = "Will Smith", PhotoUrl = "WillSmith.jpg" },
    new Actor { Id = 14, ActorName = "Christian Bale", PhotoUrl = "ChristianBale.jpg" },
    new Actor { Id = 15, ActorName = "Natalie Portman", PhotoUrl = "NataliePortman.jpg" },
    new Actor { Id = 16, ActorName = "Hugh Jackman", PhotoUrl = "HughJackman.jpg" },
    new Actor { Id = 17, ActorName = "Emma Watson", PhotoUrl = "EmmaWatson.jpg" },
    new Actor { Id = 18, ActorName = "Matthew McConaughey", PhotoUrl = "MatthewMcConaughey.jpg" },
    new Actor { Id = 19, ActorName = "Angelina Jolie", PhotoUrl = "AngelinaJolie.jpg" },
    new Actor { Id = 20, ActorName = "Ryan Reynolds", PhotoUrl = "RyanReynolds.jpg" },
    new Actor { Id = 21, ActorName = "George Clooney", PhotoUrl = "GeorgeClooney.jpg" },
    new Actor { Id = 22, ActorName = "Julia Roberts", PhotoUrl = "JuliaRoberts.jpg" },
    new Actor { Id = 23, ActorName = "Matt Damon", PhotoUrl = "MattDamon.jpg" },
    new Actor { Id = 24, ActorName = "Keanu Reeves", PhotoUrl = "KeanuReeves.jpg" },
    new Actor { Id = 25, ActorName = "Charlize Theron", PhotoUrl = "CharlizeTheron.jpg" },
    new Actor { Id = 26, ActorName = "Anne Hathaway", PhotoUrl = "AnneHathaway.jpg" },
    new Actor { Id = 27, ActorName = "Harrison Ford", PhotoUrl = "HarrisonFord.jpg" },
    new Actor { Id = 28, ActorName = "Chris Hemsworth", PhotoUrl = "ChrisHemsworth.jpg" },
    new Actor { Id = 29, ActorName = "Robert De Niro", PhotoUrl = "RobertDeNiro.jpg" },
    new Actor { Id = 30, ActorName = "Al Pacino", PhotoUrl = "AlPacino.jpg" },
    new Actor { Id = 31, ActorName = "Zendaya", PhotoUrl = "Zendaya.jpg" },
    new Actor { Id = 32, ActorName = "Timothée Chalamet", PhotoUrl = "TimothéeChalamet.jpg" },
    new Actor { Id = 33, ActorName = "Tom Holland", PhotoUrl = "TomHolland.jpg" },
    new Actor { Id = 34, ActorName = "Emma Stone", PhotoUrl = "EmmaStone.jpg" },
    new Actor { Id = 35, ActorName = "Margot Robbie", PhotoUrl = "MargotRobbie.jpg" },
    new Actor { Id = 36, ActorName = "Ryan Gosling", PhotoUrl = "RyanGosling.jpg" },
    new Actor { Id = 37, ActorName = "Daisy Ridley", PhotoUrl = "DaisyRidley.jpg" },
    new Actor { Id = 38, ActorName = "Adam Driver", PhotoUrl = "AdamDriver.jpg" },
    new Actor { Id = 39, ActorName = "John Boyega", PhotoUrl = "JohnBoyega.jpg" },
    new Actor { Id = 40, ActorName = "Oscar Isaac", PhotoUrl = "OscarIsaac.jpg" },
    new Actor { Id = 41, ActorName = "Benedict Cumberbatch", PhotoUrl = "BenedictCumberbatch.jpg" },
    new Actor { Id = 42, ActorName = "Rami Malek", PhotoUrl = "RamiMalek.jpg" },
    new Actor { Id = 43, ActorName = "Jason Momoa", PhotoUrl = "JasonMomoa.jpg" },
    new Actor { Id = 44, ActorName = "Zac Efron", PhotoUrl = "ZacEfron.jpg" },
    new Actor { Id = 45, ActorName = "Shailene Woodley", PhotoUrl = "ShaileneWoodley.jpg" },
    new Actor { Id = 46, ActorName = "Idris Elba", PhotoUrl = "IdrisElba.jpg" },
    new Actor { Id = 47, ActorName = "Rebecca Ferguson", PhotoUrl = "RebeccaFerguson.jpg" },
    new Actor { Id = 48, ActorName = "Emily Blunt", PhotoUrl = "EmilyBlunt.jpg" },
    new Actor { Id = 49, ActorName = "Paul Rudd", PhotoUrl = "PaulRudd.jpg" },
    new Actor { Id = 50, ActorName = "Mila Kunis", PhotoUrl = "MilaKunis.jpg" },
    new Actor { Id = 51, ActorName = "Gal Gadot", PhotoUrl = "GalGadot.jpg" },
    new Actor { Id = 52, ActorName = "Anya Taylor-Joy", PhotoUrl = "AnyaTaylorJoy.jpg" },
    new Actor { Id = 53, ActorName = "Michael Fassbender", PhotoUrl = "MichaelFassbender.jpg" },
    new Actor { Id = 54, ActorName = "Tessa Thompson", PhotoUrl = "TessaThompson.jpg" },
    new Actor { Id = 55, ActorName = "Jared Leto", PhotoUrl = "JaredLeto.jpg" },
    new Actor { Id = 56, ActorName = "Eiza González", PhotoUrl = "EizaGonzález.jpg" },
    new Actor { Id = 57, ActorName = "Elizabeth Debicki", PhotoUrl = "ElizabethDebicki.jpg" },
    new Actor { Id = 58, ActorName = "Tom Hardy", PhotoUrl = "TomHardy.jpg" },
    new Actor { Id = 59, ActorName = "Mads Mikkelsen", PhotoUrl = "MadsMikkelsen.jpg" },
    new Actor { Id = 60, ActorName = "Xolo Mariduena", PhotoUrl = "XoloMariduena.jpg" },
    new Actor { Id = 61, ActorName = "Liam Cunningham", PhotoUrl = "LiamCunningham.jpg" },
    new Actor { Id = 62, ActorName = "Jason Statham", PhotoUrl = "JasonStatham.jpg" },
    new Actor { Id = 63, ActorName = "Orlando Bloom", PhotoUrl = "OrlandoBloom.jpg" },
    new Actor { Id = 64, ActorName = "Mark Wahlberg ", PhotoUrl = "MarkWahlberg.jpg" },
    new Actor { Id = 65, ActorName = "Storm Reid", PhotoUrl = "StormReid.jpg" },
    new Actor { Id = 66, ActorName = "Megan Suri", PhotoUrl = "MeganSuri.jpg" },
    new Actor { Id = 67, ActorName = "Leslie Odom Jr.", PhotoUrl = "LeslieOdomJr.jpg" },
    new Actor { Id = 68, ActorName = "Pete Davidson", PhotoUrl = "PeteDavidson.jpg" },
    new Actor { Id = 69, ActorName = "John Cena", PhotoUrl = "JohnCena.jpg" },
    new Actor { Id = 70, ActorName = "Kristen Bell", PhotoUrl = "KristenBell.jpg" }

    );
    }

}

