﻿using TeDoWeb.Library.Models;

namespace TeDoWeb.Library.Services
{
    public class TestDocumentService : ITestDocumentService
    {
        private readonly IStorageService _storageService;

        public TestDocumentService(IStorageService storageService)
        {
            _storageService = storageService;
        }

        public List<TestDocument> GetAll()
        {
            return _storageService.TestDocuments.ToList() ?? throw new ArgumentNullException(nameof(_storageService.TestDocuments));
        }

        public TestDocument? GetById(int id)
        {
            return _storageService.TestDocuments.FirstOrDefault(t => t.Id == id);
        }

        public TestDocument? GetBySlug(string slug)
        {
            return _storageService.TestDocuments.FirstOrDefault(t => t.Slug == slug);
        }
    }
}
