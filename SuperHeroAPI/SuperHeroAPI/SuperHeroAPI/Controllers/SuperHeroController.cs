using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI.Models;

namespace SuperHeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
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

        [HttpGet]
        public async Task<IActionResult> GetAllHeroes()
        {
            return Ok(superheroes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingleHero(int id)
        {
            
            var hero = superheroes.Find(x => x.Id == id);
            if (hero is null) return NotFound("Error XD !");
            return Ok(hero);
        }

        [HttpPost]
        public async Task<IActionResult> AddHero(SuperHero hero)
        {
            superheroes.Add(hero);
            return Ok(superheroes);
        }
    }
}
