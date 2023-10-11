using ExerciceFilm.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceFilm.EntityConfig
{
    public class FilmConfig : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            ModelBuilder modelBuilder = new ModelBuilder();
            // Définir l'ID comme clé primaire
            builder.HasKey(f => f.Id);

            // Définir le titre comme unique
            builder.HasIndex(f => f.Title).IsUnique();
            builder.HasCheckConstraint("CK_MinYear", "ReleaseYear >= 1975");

            builder.Property(nameof(Film.Title)).IsRequired().HasColumnType("VARCHAR(100)");
            builder.Property(nameof(Film.ReleaseYear)).IsRequired();
            builder.Property(nameof(Film.RealisatorId)).IsRequired();
            //builder.Property(nameof(Film.ActeurPrincipal)).IsRequired().HasColumnType("VARCHAR(100)");
            builder.Property(nameof(Film.Genre)).IsRequired().HasColumnType("VARCHAR(100)");

            modelBuilder.Entity<Personne>().HasMany(p => p.Films).WithOne(r => r.Realisator);

            builder.ToTable(nameof(Film));
            
            builder.HasData(
                new Film
                {
                    Id = 1,
                    Title = "Star Wars : Un nouvel espoir",
                    ReleaseYear = 1977,
                    Genre = "Science-Fiction",
                    RealisatorId = 10
                },
                new Film
                {
                    Id = 2,
                    Title = "Star Wars : L'empire contre-attaque",
                    ReleaseYear = 1980,
                    Genre = "Science-Fiction",
                    RealisatorId = 10
                },
                new Film
                {
                    Id = 3,
                    Title = "Star Wars : Le retour du Jedi",
                    ReleaseYear = 1983,
                    Genre = "Science-Fiction",
                    RealisatorId = 10
                },
                new Film
                {
                    Id = 4,
                    Title = "Hooligans",
                    ReleaseYear = 2005,
                    Genre = "Société",
                    RealisatorId = 8
                },
                new Film
                {
                    Id = 5,
                    Title = "LOTR - La communauté de l'anneau",
                    ReleaseYear = 2001,
                    Genre = "Heroic-Fantasy",
                    RealisatorId = 9
                },
                new Film
                {
                    Id = 6,
                    Title = "LOTR - Les deux tours",
                    ReleaseYear = 2002,
                    Genre = "Heroic-Fantasy",
                    RealisatorId = 9
                },
                new Film
                {
                    Id = 7,
                    Title = "LOTR - Le retour du roi",
                    ReleaseYear = 2003,
                    Genre = "Heroic-Fantasy",
                    RealisatorId = 9
                });
        }
    }
}
