﻿// <auto-generated />
using ExerciceFilm.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExerciceFilm.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231011135630_m2")]
    partial class m2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExerciceFilm.Entities.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<int>("RealisatorId")
                        .HasColumnType("int");

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("Id");

                    b.HasIndex("RealisatorId");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("Film", null, t =>
                        {
                            t.HasCheckConstraint("CK_MinYear", "ReleaseYear >= 1975");
                        });

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Genre = "Science-Fiction",
                            RealisatorId = 10,
                            ReleaseYear = 1977,
                            Title = "Star Wars : Un nouvel espoir"
                        },
                        new
                        {
                            Id = 2,
                            Genre = "Science-Fiction",
                            RealisatorId = 10,
                            ReleaseYear = 1980,
                            Title = "Star Wars : L'empire contre-attaque"
                        },
                        new
                        {
                            Id = 3,
                            Genre = "Science-Fiction",
                            RealisatorId = 10,
                            ReleaseYear = 1983,
                            Title = "Star Wars : Le retour du Jedi"
                        },
                        new
                        {
                            Id = 4,
                            Genre = "Société",
                            RealisatorId = 8,
                            ReleaseYear = 2005,
                            Title = "Hooligans"
                        },
                        new
                        {
                            Id = 5,
                            Genre = "Heroic-Fantasy",
                            RealisatorId = 9,
                            ReleaseYear = 2001,
                            Title = "LOTR - La communauté de l'anneau"
                        },
                        new
                        {
                            Id = 6,
                            Genre = "Heroic-Fantasy",
                            RealisatorId = 9,
                            ReleaseYear = 2002,
                            Title = "LOTR - Les deux tours"
                        },
                        new
                        {
                            Id = 7,
                            Genre = "Heroic-Fantasy",
                            RealisatorId = 9,
                            ReleaseYear = 2003,
                            Title = "LOTR - Le retour du roi"
                        });
                });

            modelBuilder.Entity("ExerciceFilm.Entities.FilmPersonneJoin", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("PersonneId")
                        .HasColumnType("int");

                    b.HasKey("Id", "PersonneId");

                    b.HasIndex("PersonneId");

                    b.ToTable("FilmPersonneJoin", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PersonneId = 3
                        },
                        new
                        {
                            Id = 1,
                            PersonneId = 4
                        },
                        new
                        {
                            Id = 1,
                            PersonneId = 5
                        },
                        new
                        {
                            Id = 2,
                            PersonneId = 3
                        },
                        new
                        {
                            Id = 2,
                            PersonneId = 4
                        },
                        new
                        {
                            Id = 2,
                            PersonneId = 5
                        },
                        new
                        {
                            Id = 3,
                            PersonneId = 3
                        },
                        new
                        {
                            Id = 3,
                            PersonneId = 4
                        },
                        new
                        {
                            Id = 3,
                            PersonneId = 5
                        },
                        new
                        {
                            Id = 4,
                            PersonneId = 1
                        },
                        new
                        {
                            Id = 4,
                            PersonneId = 2
                        },
                        new
                        {
                            Id = 5,
                            PersonneId = 1
                        },
                        new
                        {
                            Id = 5,
                            PersonneId = 6
                        },
                        new
                        {
                            Id = 5,
                            PersonneId = 7
                        },
                        new
                        {
                            Id = 6,
                            PersonneId = 1
                        },
                        new
                        {
                            Id = 6,
                            PersonneId = 6
                        },
                        new
                        {
                            Id = 6,
                            PersonneId = 7
                        },
                        new
                        {
                            Id = 7,
                            PersonneId = 1
                        },
                        new
                        {
                            Id = 7,
                            PersonneId = 6
                        },
                        new
                        {
                            Id = 7,
                            PersonneId = 7
                        });
                });

            modelBuilder.Entity("ExerciceFilm.Entities.Personne", b =>
                {
                    b.Property<int>("PersonneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonneId"));

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("PersonneId");

                    b.ToTable("Personne", (string)null);

                    b.HasData(
                        new
                        {
                            PersonneId = 1,
                            Nom = "Wood",
                            Prenom = "Elijah"
                        },
                        new
                        {
                            PersonneId = 2,
                            Nom = "Hunnam",
                            Prenom = "Charlie"
                        },
                        new
                        {
                            PersonneId = 3,
                            Nom = "Ford",
                            Prenom = "Harisson"
                        },
                        new
                        {
                            PersonneId = 4,
                            Nom = "Hammil",
                            Prenom = "Mark"
                        },
                        new
                        {
                            PersonneId = 5,
                            Nom = "Fisher",
                            Prenom = "Carrie"
                        },
                        new
                        {
                            PersonneId = 6,
                            Nom = "Mortensen",
                            Prenom = "Vigo"
                        },
                        new
                        {
                            PersonneId = 7,
                            Nom = "Bloom",
                            Prenom = "Orlando"
                        },
                        new
                        {
                            PersonneId = 8,
                            Nom = "Alexander",
                            Prenom = "Lexi"
                        },
                        new
                        {
                            PersonneId = 9,
                            Nom = "Jackson",
                            Prenom = "Peter"
                        },
                        new
                        {
                            PersonneId = 10,
                            Nom = "Lucas",
                            Prenom = "Georges"
                        });
                });

            modelBuilder.Entity("ExerciceFilm.Entities.Film", b =>
                {
                    b.HasOne("ExerciceFilm.Entities.Personne", "Realisator")
                        .WithMany("Films")
                        .HasForeignKey("RealisatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Realisator");
                });

            modelBuilder.Entity("ExerciceFilm.Entities.FilmPersonneJoin", b =>
                {
                    b.HasOne("ExerciceFilm.Entities.Film", "Film")
                        .WithMany("FilmjoinsPersonne")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ExerciceFilm.Entities.Personne", "Personne")
                        .WithMany("PersonneJoinsFilm")
                        .HasForeignKey("PersonneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Film");

                    b.Navigation("Personne");
                });

            modelBuilder.Entity("ExerciceFilm.Entities.Film", b =>
                {
                    b.Navigation("FilmjoinsPersonne");
                });

            modelBuilder.Entity("ExerciceFilm.Entities.Personne", b =>
                {
                    b.Navigation("Films");

                    b.Navigation("PersonneJoinsFilm");
                });
#pragma warning restore 612, 618
        }
    }
}
