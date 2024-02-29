using System.Runtime.Serialization;
using TeDo.Libraries.Models;

namespace TeDo.Libraries
{
    public interface ITestDocumentService
    { 
        TestDocument? GetById(int id);
        TestDocument? GetBySlug(string slug);
        List<TestDocument> GetAll();
    }
}
