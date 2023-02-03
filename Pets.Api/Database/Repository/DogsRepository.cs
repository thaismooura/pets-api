using Pets.Api.Models;

namespace Pets.Api.Database.Repository
{
    public class DogsRepository : RavenDbRepository<Dog>, IDogsRepository
    {
        public async Task AddDogs(Dog dog)
        {
            await AddOrUpdate(dog);
        }

        public async Task DeleteDogs(string id)
        {
            await Delete(id);
        }

        public IEnumerable<Dog> GetDogs(double height)
        {
            return Get(_ => Math.Abs(_.Height - height) < 0.5);
        }

        public Dog GetDog(double height)
        {
            return GetOne(_ => Math.Abs(_.Height - height) < 0.5);
        }
    }
}