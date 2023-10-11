using ExerciceFilm.Entities;
using ExerciceFilm.EntityConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceFilm.Domain
{
    public class DataContext : DbContext
    {
        private string _connectionString = @"Data Source=DESKTOP-0PJ4SJR;Initial Catalog=Entity;Integrated Security=True;Encrypt=False;";
        public DbSet<Film> FilmList { get; set; }
        public DbSet<Personne> PersonneList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FilmConfig());
            modelBuilder.ApplyConfiguration(new PersonneConfig());
            modelBuilder.ApplyConfiguration(new FilmPersonneConfig());
        }
    }
}
