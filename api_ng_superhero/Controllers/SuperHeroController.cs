using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_ng_superhero.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetSuperHeroes()
        {
            return new List<SuperHero>
        { new SuperHero {
        Nick="edderkopp man",
        FirstName="dave",
        LastName="saga",
        Place="agder"
        }
        };
        }
    }
}
