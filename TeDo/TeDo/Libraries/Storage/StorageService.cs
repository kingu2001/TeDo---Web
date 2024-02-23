using System.Net.Http.Json;

namespace TeDo.Libraries;

public class StorageService : IStorageService
{
    public List<TestDocument> TestDocuments { get; private set; }

    public StorageService()
    {
        TestDocuments = new List<TestDocument>();
    }

    public async Task PopulateList()
    {
        HttpClient httpClient = new HttpClient();
        var response = await httpClient.GetAsync("https://localhost:7105/api/TestDocument");

        if(response.IsSuccessStatusCode)
        {
            var result = await response.Content.ReadFromJsonAsync<List<TestDocument>>();

            if(result!= null)
            {
                TestDocuments = result;
            }
            else
            {
				throw new Exception("Result of API call was null");
            }
        }
        else
        {
	        throw new Exception("API call returned: " + response.StatusCode.ToString());
        }
    }
}
