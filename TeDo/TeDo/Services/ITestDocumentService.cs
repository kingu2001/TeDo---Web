﻿namespace TeDo.Libraries;

public interface ITestDocumentService
{
    TestDocument? GetById(int id);
    TestDocument? GetBySlug(string slug);
    List<TestDocument> GetAll();
}