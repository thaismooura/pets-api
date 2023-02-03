using Pets.Api.Database.DatabaseSettings;
using Raven.Client.Documents;

namespace Pets.Api.Database.Provider
{
    public class DocumentStoreHolder
    {
        public static IDocumentStore Store => CreateStore();

        private static IDocumentStore CreateStore()
        {
            var store = new DocumentStore()
            {
                Urls = new[] { RavenDbSettings.RavenUrl },

                Database = RavenDbSettings.DatabaseName,
            }.Initialize();

            return store;
        }
    }
}