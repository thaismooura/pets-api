using Microsoft.AspNetCore.Mvc;
using Pets.Api.Database.Repository;
using Pets.Api.Models;

namespace Pets.Api.Controllers
{
    [ApiController]
    [Route("api/pets")]
    public class PetsController : ControllerBase
    {
        private readonly IDogsRepository _dogsRepository;

        public PetsController(IDogsRepository dogsRepository)
        {
            _dogsRepository = dogsRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddDogs(Dog dog)
        {
           await _dogsRepository.AddDogs(dog);

            return NoContent();
        }
    }
}
