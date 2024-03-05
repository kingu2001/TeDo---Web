using TeDoWebApp.Libraries.Models;

namespace TeDoWebApp.Libraries
{
    public interface IStorageService
    {
        IList<TestDocument> TestDocuments { get; }

        Task PopulateList();
    }
}
