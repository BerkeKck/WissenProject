using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using eTickets.Entities.Model.Concrete;
using eTickets.Entities.EntityConfig.Abstract;

namespace eTickets.Entities.EntityConfig.Concrete
{
    public class CategoryConfig : BaseConfig<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);
            builder.HasData(
                new Category { Id = 1, CategoryName = "Action" },
                new Category { Id = 2, CategoryName = "Drama" },
                new Category { Id = 3, CategoryName = "Comedy" },
                new Category { Id = 4, CategoryName = "Horror" },
                new Category { Id = 5, CategoryName = "Sci-Fi" },
                new Category { Id = 6, CategoryName = "Romance" },
                new Category { Id = 7, CategoryName = "Adventure" },
                new Category { Id = 8, CategoryName = "Fantasy" },
                new Category { Id = 9, CategoryName = "Thriller" },
                new Category { Id = 10, CategoryName = "Documentary" },
                new Category { Id = 11, CategoryName = "Family" },
                new Category { Id = 12, CategoryName = "Animation" },
                new Category { Id = 13, CategoryName = "Blu Ray" },
                new Category { Id = 14, CategoryName = "Cartoons" },
                new Category { Id = 15, CategoryName = "Mystery" },
                new Category { Id = 16, CategoryName = "Indian" },
                new Category { Id = 17, CategoryName = "Musical" },
                new Category { Id = 18, CategoryName = "Crime" },
                new Category { Id = 19, CategoryName = "Psychological" },
                new Category { Id = 20, CategoryName = "War" },
                new Category { Id = 21, CategoryName = "Historical" }
            );

        }
    }
}

