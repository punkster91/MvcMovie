using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                // do nothing if database is already seeded
                if (context.Movie.Any()) return;

                #region Genres
                Genre[] genres = {
                    new() { Id = 1, Name = "Action"},
                    new() { Id = 2, Name = "Comedy"},
                    new() { Id = 3, Name = "Horror"},
                    new() { Id = 4, Name = "Scifi"},
                    new() { Id = 5, Name = "Musical"},
                    new() { Id = 6, Name = "Thriller"},
                    new() { Id = 7, Name = "Adventure"},
                    new() { Id = 8, Name = "Mystery"},
                    new() { Id = 9, Name = "Fantasy"},
                    new() { Id = 10, Name = "Drama"}
                };
                context.Genres.AddRange(genres);
                context.SaveChanges();
                #endregion

                #region Countries
                Country[] countries =
                {
                    new() { Id = 1, Name = "United States of America", Abbreviation = "USA"},
                    new() { Id = 2, Name = "Argentina", Abbreviation = "AR"},
                    new() { Id = 3, Name = "Belgium", Abbreviation = "BE"},
                    new() { Id = 4, Name = "China", Abbreviation = "CN"},
                    new() { Id = 5, Name = "Finland", Abbreviation = "FI"},
                    new() { Id = 6, Name = "Korea", Abbreviation = "KR"},
                    new() { Id = 7, Name = "Japan", Abbreviation = "JP"},
                    new() { Id = 8, Name = "France", Abbreviation = "FR"},
                    new() { Id = 9, Name = "Norway", Abbreviation = "NO"},
                    new() { Id = 10, Name = "Pakistan", Abbreviation = "PK"}
                };
                context.Countries.AddRange(countries);
                context.SaveChanges();
                #endregion

                #region Movies
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Deadpool and Wolverine",
                        ReleaseDate = DateTime.Parse("2024-7-26"),
                        Genres = [genres.ElementAt(0), genres.ElementAt(1)],
                        Rating = "R",
                        Description = "A listless Wade Wilson toils away in civilian life with his days as the morally flexible mercenary, Deadpool, behind him. But when his homeworld faces an existential threat, Wade must reluctantly suit-up again with an even more reluctant Wolverine.",
                        Country = countries.ElementAt(0),
                        CountryId = countries.ElementAt(0).Id,
                        Duration = 127,
                        Media = new Media
                        {
                            BaseImagePath = "/assets/movies/deadpool-and-wolverine-base.jpg",
                            ThumbnailPath = "/assets/movies/deadpool-and-wolverine-thumbnail.jpg"
                        }
                    },
                new Movie
                {
                    Title = "Red One",
                    ReleaseDate = DateTime.Parse("2024-11-15"),
                    Genres = [genres.ElementAt(0), genres.ElementAt(1)],
                    Rating = "PG-13",
                    Description = "After Santa Claus (code name: Red One) is kidnapped, the North Pole's Head of Security (Dwayne Johnson) must team up with the world's most infamous bounty hunter (Chris Evans) in a globe-trotting, action-packed mission to save Christmas.",
                    Country = countries.ElementAt(0),
                    CountryId = countries.ElementAt(0).Id,
                    Duration = 124,                 
                    Media = new Media
                    {
                        BaseImagePath = "/assets/movies/red-one-base.jpg",
                        ThumbnailPath = "/assets/movies/red-one-thumbnail.jpg"
                    }
                },
                new Movie
                {
                    Title = "Alien: Romulus",
                    ReleaseDate = DateTime.Parse("2024-8-16"),
                    Genres = [genres.ElementAt(2), genres.ElementAt(3)],
                    Rating = "R",
                    Description = "While scavenging the deep ends of a derelict space station, a group of young space colonizers come face to face with the most terrifying life form in the universe.",
                    Country = countries.ElementAt(0),
                    CountryId = countries.ElementAt(0).Id,
                    Duration = 119,
                    Media = new Media
                    {
                        BaseImagePath = "assets/movies/alien-romulus-base.jpg",
                        ThumbnailPath = "assets/movies/alien-romulus-thumbnail.jpg"
                    }
                },
                new Movie
                {
                    Title = "Joker: Folie a Deux",
                    ReleaseDate = DateTime.Parse("2024-10-01"),
                    Genres = [genres.ElementAt(4), genres.ElementAt(5)],
                    Rating = "R",
                    Description = "While struggling with his dual identity, Arthur Fleck not only stumbles upon true love, but also finds the music that's always been inside him.",
                    Country = countries.ElementAt(0),
                    CountryId = countries.ElementAt(0).Id,
                    Duration = 138,
                    Media = new Media
                    {
                        BaseImagePath = "assets/movies/joker-base.jpg",
                        ThumbnailPath = "assets/movies/joker-thumbnail.jpg"
                    }
                }, 
                new Movie
                {
                    Title = "Alien",
                    ReleaseDate = DateTime.Parse("1979-05-25"),
                    Genres = [genres.ElementAt(2), genres.ElementAt(3)],
                    Rating = "R",
                    Description = "During its return to the earth, commercial spaceship Nostromo intercepts a distress signal from a distant planet. When a three-member team of the crew discovers a chamber containing thousands of eggs on the planet, a creature inside one of the eggs attacks an explorer. The entire crew is unaware of the impending nightmare set to descend upon them when the alien parasite planted inside its unfortunate host is birthed.",
                    Country = countries.ElementAt(0),
                    CountryId = countries.ElementAt(0).Id,
                    Duration = 117,
                    Media = new Media
                    {
                        BaseImagePath = "assets/movies/alien-base.jpg",
                        ThumbnailPath = "assets/movies/alien-thumbnail.jpg"
                    }
                },
                new Movie
                {
                    Title = "Aliens",
                    ReleaseDate = DateTime.Parse("1986-07-18"),
                    Genres = [genres.ElementAt(2), genres.ElementAt(3)],
                    Rating = "R",
                    Description = "When Ripley's lifepod is found by a salvage crew over 50 years later, she finds that terra-formers are on the very planet they found the alien species. When the company sends a family of colonists out to investigate her story—all contact is lost with the planet and colonists. They enlist Ripley and the colonial marines to return and search for answers.",
                    Country = countries.ElementAt(0),
                    CountryId = countries.ElementAt(0).Id,
                    Duration = 137,
                    Media = new Media
                    {
                        BaseImagePath = "assets/movies/aliens-base.jpg",
                        ThumbnailPath = "assets/movies/aliens-thumbnail.jpg"
                    }
                },
                new Movie
                {
                    Title = "Alien Resurrection",
                    ReleaseDate = DateTime.Parse("1997-11-12"),
                    Genres = [genres.ElementAt(2), genres.ElementAt(3)],
                    Rating = "R",
                    Description = "Two hundred years after Lt. Ripley died, a group of scientists clone her, hoping to breed the ultimate weapon. But the new Ripley is full of surprises … as are the new aliens. Ripley must team with a band of smugglers to keep the creatures from reaching Earth.",
                    Country = countries.ElementAt(0),
                    CountryId = countries.ElementAt(0).Id,
                    Duration = 109,
                    Media = new Media
                    {
                        BaseImagePath = "assets/movies/alien-resurrection-base.jpg",
                        ThumbnailPath = "assets/movies/alien-resurrection-thumbnail.jpg"
                    }
                },
                new Movie
                {
                    Title = "Prometheus",
                    ReleaseDate = DateTime.Parse("2012-05-30"),
                    Genres = [genres.ElementAt(2), genres.ElementAt(3)],
                    Rating = "R",
                    Description = "A team of explorers discover a clue to the origins of mankind on Earth, leading them on a journey to the darkest corners of the universe. There, they must fight a terrifying battle to save the future of the human race.",
                    Country = countries.ElementAt(0),
                    CountryId = countries.ElementAt(0).Id,
                    Duration = 124,
                    Media = new Media
                    {
                        BaseImagePath = "assets/movies/prometheus-base.jpg",
                        ThumbnailPath = "assets/movies/prometheus-thumbnail.jpg"
                    }
                },
                new Movie
                {
                    Title = "Alien Covenant",
                    ReleaseDate = DateTime.Parse("2017-05-09"),
                    Genres = [genres.ElementAt(2), genres.ElementAt(3)],
                    Rating = "R",
                    Description = "Bound for a remote planet on the far side of the galaxy, the crew of the colony ship 'Covenant' discovers what is thought to be an uncharted paradise, but is actually a dark, dangerous world—which has a sole inhabitant: the 'synthetic', David, survivor of the doomed Prometheus expedition.",
                    Country = countries.ElementAt(0),
                    CountryId = countries.ElementAt(0).Id,
                    Duration = 122,
                    Media = new Media
                    {
                        BaseImagePath = "assets/movies/alien-covenant-base.jpg",
                        ThumbnailPath = "assets/movies/alien-covenant-thumbnail.jpg"
                    }
                });
                context.SaveChanges();
                #endregion
            }
        }
    }
}
