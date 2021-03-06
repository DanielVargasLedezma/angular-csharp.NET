using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SuperHero_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        [HttpGet]
        public async Task<List<SuperHero>> GetSuperHeroes()
        {
            return new List<SuperHero>
            {
                new SuperHero
                {
                    SuperHeroName = "Spider Man",
                    FirstName = "Peter",
                    LastName = "Parker",
                    Place = "Queens"
                }
            };
        }
    }
}
