using Raven.Client.Documents;

namespace Pets.Api.Database.Provider;

public interface IDatabaseProvider
{
    public void CreateDatabase();
    static IDocumentStore Store { get; }
    void EnsureDatabaseExists(IDocumentStore store, string database = null, bool createDatabaseIfNotExists = true);
}