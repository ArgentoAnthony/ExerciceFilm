using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceFilm.Entities
{
    public class FilmPersonneJoin
    {
        public int Id { get; set; }
        public int PersonneId { get; set; }
        public Film Film { get; set; }
        public Personne Personne { get; set; }
    }
}
