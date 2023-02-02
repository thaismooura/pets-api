using Pets.Api.Models;

namespace Pets.Api.Database.Repository;

public interface IDogsRepository
{
    Task AddDogs(Dog dog);
}