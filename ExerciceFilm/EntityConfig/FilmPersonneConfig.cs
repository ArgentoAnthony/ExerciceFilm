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
    public class FilmPersonneConfig : IEntityTypeConfiguration<FilmPersonneJoin>
    {
        public void Configure(EntityTypeBuilder<FilmPersonneJoin> builder)
        {
            builder.HasKey(x => new {x.Id, x.PersonneId});

            builder.HasOne(p => p.Personne)
                    .WithMany(x => x.PersonneJoinsFilm)
                    .HasForeignKey(fk => fk.PersonneId);

            builder.HasOne(f => f.Film)
                    .WithMany(x => x.FilmjoinsPersonne)
                    .HasForeignKey(fk => fk.Id).OnDelete(DeleteBehavior.Restrict);

            builder.ToTable(nameof(FilmPersonneJoin));
            builder.HasData
                (
                    new FilmPersonneJoin { Id = 1, PersonneId = 3 },
                    new FilmPersonneJoin { Id = 1, PersonneId = 4 },
                    new FilmPersonneJoin { Id = 1, PersonneId = 5 },
                    new FilmPersonneJoin { Id = 2, PersonneId = 3 },
                    new FilmPersonneJoin { Id = 2, PersonneId = 4 },
                    new FilmPersonneJoin { Id = 2, PersonneId = 5 },
                    new FilmPersonneJoin { Id = 3, PersonneId = 3 },
                    new FilmPersonneJoin { Id = 3, PersonneId = 4 },
                    new FilmPersonneJoin { Id = 3, PersonneId = 5 },
                    new FilmPersonneJoin { Id = 4, PersonneId = 1 },
                    new FilmPersonneJoin { Id = 4, PersonneId = 2 },
                    new FilmPersonneJoin { Id = 5, PersonneId = 1 },
                    new FilmPersonneJoin { Id = 5, PersonneId = 6 },
                    new FilmPersonneJoin { Id = 5, PersonneId = 7 },
                    new FilmPersonneJoin { Id = 6, PersonneId = 1 },
                    new FilmPersonneJoin { Id = 6, PersonneId = 6 },
                    new FilmPersonneJoin { Id = 6, PersonneId = 7 },
                    new FilmPersonneJoin { Id = 7, PersonneId = 1 },
                    new FilmPersonneJoin { Id = 7, PersonneId = 6 },
                    new FilmPersonneJoin { Id = 7, PersonneId = 7 }
                );

        }
    }
}
