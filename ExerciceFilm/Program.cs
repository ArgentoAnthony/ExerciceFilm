using ExerciceFilm.Domain;
using ExerciceFilm.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

DataContext dataContext = new DataContext();

//dataContext.FilmList.Add(new Film
//{
//    Titre = "Pacific Rim",
//    AnneeDeSortie = 2013,
//    Realisateur = "Guillermo Del Toro",
//    ActeurPrincipal = "Charlie Hunnam",
//    Genre = "Action"
//});

//dataContext.SaveChanges();

//foreach (Film f in dataContext.FilmList.Where(x => x.AnneeDeSortie < 2001))
//{
//    Console.WriteLine($"Titre : {f.Titre}\tGenre : {f.Genre} ");
//}

//foreach(Film f in dataContext.FilmList.Where(x => x.Titre.Contains("Star Wars")))
//{
//    f.ActeurPrincipal = "Harrison Ford";
//}
//dataContext.SaveChanges();

//foreach(Film f in dataContext.FilmList.Where(x => x.ActeurPrincipal.Contains("Charlie Hunnam")))
//{
//    dataContext.Remove(f);
//}
//dataContext.SaveChanges();

foreach (Film f in dataContext.FilmList.Include(x => x.FilmjoinsPersonne).ThenInclude(f => f.Personne).Include(r => r.Realisator))
{
    Console.WriteLine($"Titre : {f.Title} - Réalisateur: Nom: {f.Realisator.Nom} Prénom: {f.Realisator.Prenom}");
    // Faire un second foreach pour afficher la liste des acteurs (Film => FilmjoinsPersonne)
}




