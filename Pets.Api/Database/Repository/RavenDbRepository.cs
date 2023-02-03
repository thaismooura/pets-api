using Pets.Api.Database.Provider;
using Pets.Api.Exceptions;

namespace Pets.Api.Database.Repository
{
    public class RavenDbRepository<T>
    {
        protected async Task Add(T entity)
        {
            var session = DatabaseProvider.Store.OpenAsyncSession();

            await session.StoreAsync(entity);

            await session.SaveChangesAsync();
        }

        protected async Task Delete(string id)
        {
            var session = DatabaseProvider.Store.OpenAsyncSession();

            session.Delete(id);

            await session.SaveChangesAsync();
        }

        protected IEnumerable<T> Get(Func<T, bool> where)
        {
            var session = DatabaseProvider.Store.OpenSession();

            var query = session.Query<T>().Where(where);

            return query;
        }

        protected T GetOne(Func<T, bool> where)
        {
            var session = DatabaseProvider.Store.OpenSession();

            var getOneEntity = session.Query<T>().Where(where).FirstOrDefault();
            if (getOneEntity == null) throw new EntityNotFoundException("Entity not found");

            return getOneEntity;
        }
    }
}