using TeDoWeb.Library.Models;

namespace TeDoWeb.Library.Services
{
    public interface ITestDocumentService
    { 
        TestDocument? GetById(int id);
        TestDocument? GetBySlug(string slug);
        List<TestDocument> GetAll();
    }
}
