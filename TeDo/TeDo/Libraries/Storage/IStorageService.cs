using TeDo.Libraries.Models;

namespace TeDo.Libraries;

public interface IStorageService
{
    IList<TestDocument> TestDocuments { get; }

    Task PopulateList();
}
