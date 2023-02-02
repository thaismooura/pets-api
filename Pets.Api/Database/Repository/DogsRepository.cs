using Pets.Api.Models;

namespace Pets.Api.Database.Repository
{
    public class DogsRepository : RavenDbRepository<Dog>, IDogsRepository
    {
        public async Task AddDogs(Dog dog)
        {
            await Add(dog);
        }

        public async Task DeleteDogs(string id)
        {
            await Delete(id);
        }

        public IEnumerable<Dog> GetDogs(string id)
        {
            return Get(_=>_.Id == id);
        }
    }
}
