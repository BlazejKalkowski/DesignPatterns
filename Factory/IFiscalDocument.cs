namespace Factory
{
    public interface IFiscalDocument
    {
        public string GetDocumentType();
        public decimal GetAmountOfDocument();
        public string PrintDocument();
    }
}
