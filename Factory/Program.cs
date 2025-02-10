using Factory;

Console.WriteLine("Hello, World!");

var document = new FiscalDocumentFactory();
var fiscalRecipeDocument = document.CreateFiscalDocument(DocumentType.FiscalRecipt);
fiscalRecipeDocument.PrintDocument();

var document2 = new FiscalDocumentFactory();
var invoiceDocument = document.CreateFiscalDocument(DocumentType.Invoice);
invoiceDocument.PrintDocument();

Console.ReadKey();