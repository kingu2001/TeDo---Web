using TeDoWeb.Library.Models;

namespace TeDoWeb.Library.Services
{
    public interface IStorageService
    {
        IList<TestDocument> TestDocuments { get; }

        Task PopulateList();
    }
}
