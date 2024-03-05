using System.Runtime.Serialization;
using TeDo.Libraries.Models;

namespace TeDoWebApp.Libraries
{
    public interface ITestDocumentService
    { 
        TestDocument? GetById(int id);
        TestDocument? GetBySlug(string slug);
        List<TestDocument> GetAll();
    }
}
