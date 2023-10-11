//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using ExerciceFilm.Entities;

//namespace ExerciceFilm.Domain
//{
//    public class DataSet : IEntityTypeConfiguration<Film>
//    {
//        public void Configure(EntityTypeBuilder<Film> builder)
//        {
//            builder.HasData(
//                new Film
//                {
//                    Id = 1,
//                    Title = "Star Wars : Un nouvel espoir",
//                    ReleaseYear = 1977,
//                    ActeurPrincipal = "Mark Hammil",
//                    Genre = "Science-Fiction",
//                    Realisateur = "Georges Lucas"
//                },
//                new Film
//                {
//                    Id = 2,
//                    Title = "Star Wars : L'empire contre-attaque",
//                    ReleaseYear = 1980,
//                    ActeurPrincipal = "Mark Hammil",
//                    Genre = "Science-Fiction",
//                    Realisateur = "Georges Lucas"
//                },
//                new Film
//                {
//                    Id = 3,
//                    Title = "Star Wars : Le retour du Jedi",
//                    ReleaseYear = 1983,
//                    ActeurPrincipal = "Mark Hammil",
//                    Genre = "Science-Fiction",
//                    Realisateur = "Georges Lucas"
//                },
//                new Film
//                {
//                    Id = 4,
//                    Title = "Hooligans",
//                    ReleaseYear = 2005,
//                    ActeurPrincipal = "Charlie Hunnam",
//                    Genre = "Société",
//                    Realisateur = "Lexi Alexander"
//                },
//                new Film
//                {
//                    Id = 5,
//                    Title = "LOTR - La communauté de l'anneau",
//                    ReleaseYear = 2001,
//                    ActeurPrincipal = "Elijah Wood",
//                    Genre = "Heroic-Fantasy",
//                    Realisateur = "Peter Jackson"
//                },
//                new Film
//                {
//                    Id = 6,
//                    Title = "LOTR - Les deux tours",
//                    ReleaseYear = 2002,
//                    ActeurPrincipal = "Elijah Wood",
//                    Genre = "Heroic-Fantasy",
//                    Realisateur = "Peter Jackson"
//                },
//                new Film
//                {
//                    Id = 7,
//                    Title = "LOTR - Le retour du roi",
//                    ReleaseYear = 2003,
//                    ActeurPrincipal = "Elijah Wood",
//                    Genre = "Heroic-Fantasy",
//                    Realisateur = "Peter Jackson"
//                }
//                );
//        }
//    }
//}

