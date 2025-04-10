using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;
using Bogus;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<RazorPagesMovieContext>>()))
            {
                if (context == null || context.Movie == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                if (!context.Movie.Any())
                {
                    context.Movie.AddRange(
                        new Movie
                        {
                            Title = "When Harry Met Sally",
                            ReleaseDate = DateTime.Parse("1989-2-12"),
                            Genre = "Romantic Comedy",
                            Price = 7.99M,
                            Director = "Rob Reiner",
                            Cast = "Billy Crystal, Meg Ryan",
                            IMDbRating = 7.6M,
                            BoxOfficeRevenue = 92.8M,
                            ReleaseCountry = "USA"
                        },
                        new Movie
                        {
                            Title = "Ghostbusters",
                            ReleaseDate = DateTime.Parse("1984-3-13"),
                            Genre = "Comedy",
                            Price = 8.99M,
                            Director = "Ivan Reitman",
                            Cast = "Bill Murray, Dan Aykroyd",
                            IMDbRating = 7.8M,
                            BoxOfficeRevenue = 295.2M,
                            ReleaseCountry = "USA"
                        },
                        new Movie
                        {
                            Title = "Ghostbusters 2",
                            ReleaseDate = DateTime.Parse("1986-2-23"),
                            Genre = "Comedy",
                            Price = 9.99M,
                            Director = "Ivan Reitman",
                            Cast = "Bill Murray, Dan Aykroyd, Sigourney Weaver",
                            IMDbRating = 6.6M,
                            BoxOfficeRevenue = 215.4M,
                            ReleaseCountry = "USA"
                        },
                        new Movie
                        {
                            Title = "Rio Bravo",
                            ReleaseDate = DateTime.Parse("1959-4-15"),
                            Genre = "Western",
                            Price = 3.99M,
                            Director = "Howard Hawks",
                            Cast = "John Wayne, Dean Martin",
                            IMDbRating = 8.0M,
                            BoxOfficeRevenue = 12.5M,
                            ReleaseCountry = "USA"
                        }
                    );
                    context.SaveChanges();
                }

                if (!context.Actor.Any())
                {
                    var faker = new Faker<Actor>()
                        .RuleFor(a => a.Name, f => f.Name.FullName())
                        .RuleFor(a => a.DateOfBirth, f => f.Date.Past(30, DateTime.Now.AddYears(-20)));

                    context.Actor.AddRange(faker.Generate(100));
                    context.SaveChanges();
                }
            }
        }
    }
}