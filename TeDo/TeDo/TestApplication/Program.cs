using TeDo.Libraries;

StorageService storageService = new StorageService();
await storageService.PopulateList();


foreach(TestDocument testDocument in storageService.TestDocuments)
{
    Console.WriteLine(testDocument.Name);
}