namespace Factory
{
    public class FiscalDocumentFactory
    {
        public FiscalDocument CreateFiscalDocument(DocumentType documentType)
        {
            switch (documentType)
            {
                case DocumentType.Invoice:
                    return new Invoice();
                case DocumentType.FiscalRecipt:
                    return new FiscalReceipt();
                default:
                    throw new Exception("Document is not handled");
            }
        }
    }
}
