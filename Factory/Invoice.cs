namespace Factory
{
    public class Invoice : FiscalDocument
    {
        private decimal _amount = 500;
        private string _type = "Invoice Recipt";

        public override void PrintDocument()
        {
            Console.WriteLine($"My document is {_type} and value is {_amount}");
        }
    }
}
