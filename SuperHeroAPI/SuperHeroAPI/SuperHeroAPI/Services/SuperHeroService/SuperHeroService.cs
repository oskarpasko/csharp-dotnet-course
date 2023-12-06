using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI.Models;

namespace SuperHeroAPI.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        private static List<SuperHero> superheroes = new List<SuperHero> {
                new SuperHero {
                    Id = 1,
                    Name = "Batman",
                    FirstName = "John",
                    LastName = "Wayne",
                    Place = "Gotham"
                },
                new SuperHero {
                    Id = 2,
                    Name = "Madara",
                    FirstName = "Madara",
                    LastName = "Uchiha",
                    Place = "Leaf Village"
                }
            };

        List<SuperHero> ISuperHeroService.AddHero(SuperHero hero)
        {
            superheroes.Add(hero);
            return superheroes;
        }

        List<SuperHero> ISuperHeroService.DeleteHero(int id)
        {
            var hero = superheroes.Find(x => x.Id == id);
            if (hero is null) return null;

            superheroes.Remove(hero);

            return superheroes;
        }

        List<SuperHero> ISuperHeroService.GetAllHeroes()
        {
            return superheroes;
        }

        SuperHero ISuperHeroService.GetSingleHero(int id)
        {
            var hero = superheroes.Find(x => x.Id == id);
            if (hero is null) return null;
            return hero;
        }

        List<SuperHero> ISuperHeroService.UpdateHero(int id, SuperHero request)
        {
            var hero = superheroes.Find(x => x.Id == id);
            if (hero is null) return null;

            hero.Name = request.Name;
            hero.FirstName = request.FirstName;
            hero.LastName = request.LastName;
            hero.Place = request.Place;


            return superheroes;
        }
    }
}
