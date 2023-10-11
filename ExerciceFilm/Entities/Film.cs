using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceFilm.Entities
{
    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public int RealisatorId { get; set; }
        public Personne Realisator { get; set; }
        public string Genre { get; set; }
        public List<FilmPersonneJoin> FilmjoinsPersonne { get; set; }

    }
}
