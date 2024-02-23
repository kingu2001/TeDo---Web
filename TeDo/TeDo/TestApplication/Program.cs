
using TeDo.Libraries;
using TeDo.Libraries.Models;

StorageService storageService = new StorageService();
await storageService.PopulateList();


foreach(TestDocument testDocument in storageService.TestDocuments)
{
    Console.WriteLine(testDocument.Name);
}