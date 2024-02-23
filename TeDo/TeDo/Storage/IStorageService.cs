namespace TeDo.Libraries;

public interface IStorageService
{
    List<TestDocument> TestDocuments { get; }

    Task PopulateList();
}
