using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI.Models;
using SuperHeroAPI.Services.SuperHeroService;

namespace SuperHeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {

        private readonly ISuperHeroService _superHeroService;

        public SuperHeroController(ISuperHeroService superHeroService)
        {
            _superHeroService = superHeroService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHeroes()
        {
            var result = _superHeroService.GetAllHeroes();
            if (result is null) return NotFound("Error XD !");

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingleHero(int id)
        {
            var hero = _superHeroService.GetSingleHero(id);
            if (hero is null) return NotFound("Error XD !");
            return Ok(hero);
        }

        [HttpPost]
        public async Task<IActionResult> AddHero(SuperHero hero)
        {
            var result = _superHeroService.AddHero(hero);
            if (result is null) return NotFound("Error");

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateHero(int id, SuperHero request)
        {

            var result = _superHeroService.UpdateHero(id, request);
            if (result is null) return NotFound("Error!");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHero(int id)
        {

            var result = _superHeroService.DeleteHero(id);

            if (result is null) return NotFound("Error!");
            return Ok(result);
        }
    }
}
