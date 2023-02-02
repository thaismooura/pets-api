using Pets.Api.Database.Provider;

namespace Pets.Api.Database.Repository
{
    public class RavenDbRepository<T> 
    {
        protected async Task Add(T entity)
        {
            var session =  DatabaseProvider.Store.OpenAsyncSession();

            await session.StoreAsync(entity);

            await session.SaveChangesAsync();
        }
    }
}
