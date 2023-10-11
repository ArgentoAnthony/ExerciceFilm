using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceFilm.Entities
{
    public class Personne
    {
        public int PersonneId {  get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public List<Film> Films { get; set; }
        public List<FilmPersonneJoin> PersonneJoinsFilm { get; set; }
    }
}
