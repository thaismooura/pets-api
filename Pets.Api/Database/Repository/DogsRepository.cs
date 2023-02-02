using Pets.Api.Models;

namespace Pets.Api.Database.Repository
{
    public class DogsRepository : RavenDbRepository<Dog>, IDogsRepository
    {
        public async Task AddDogs(Dog dog)
        {
            await Add(dog);
        }
    }
}
