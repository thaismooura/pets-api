namespace Pets.Api.Database.Repository;

public interface IRavenDbRepository<T>
{
    Task Add(T entity);
}