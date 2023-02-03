using Pets.Api.Models;

namespace Pets.Api.Database.Repository;

public interface IDogsRepository
{
    Task AddDogs(Dog dog);

    Task DeleteDogs(string id);

    IEnumerable<Dog> GetDogs(double height);

    Dog GetDog(double height);
}