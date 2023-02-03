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

        [HttpPost("add-dogs")]
        public async Task<IActionResult> AddDogs(Dog dog)
        {
            await _dogsRepository.AddDogs(dog);

            return NoContent();
        }

        [HttpDelete("delete-dogs")]
        public async Task<IActionResult> DeleteDogs(string id)
        {
            await _dogsRepository.DeleteDogs(id);

            return Ok();
        }

        [HttpGet("get-dogs")]
        public IActionResult GetDogs(double height)
        {
            return Ok(_dogsRepository.GetDogs(height));
        }

        [HttpGet("get-dog")]
        public IActionResult GetDog(double height)
        {
            return Ok(_dogsRepository.GetDog(height));
        }
    }
}