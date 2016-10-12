namespace MovieCatalogue.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MovieCatalogue.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MovieCatalogue.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title,
                new Movie
                {
                    Title = "Sharknado 4",
                    ReleaseDate = DateTime.Parse("2016-10-11"),
                    Genre = "Parody",
                    Rating = "PG",
                    Price = 3.75M
                },

                new Movie
                {
                    Title = "Sharknado",
                    ReleaseDate = DateTime.Parse("2012-10-11"),
                    Genre = "Parody",
                    Rating = "PG",
                    Price = 3.75M
                },

                new Movie
                {
                    Title = "Zootopia",
                    ReleaseDate = DateTime.Parse("2016-04-05"),
                    Genre = "Animation",
                    Rating = "PG",
                    Price = 3.75M
                },

                new Movie
                {
                    Title = "Batman vs Superman",
                    ReleaseDate = DateTime.Parse("2016-08-02"),
                    Genre = "Action",
                    Rating = "PG",
                    Price = 3.75M
                }
            );

        }
    }
}
