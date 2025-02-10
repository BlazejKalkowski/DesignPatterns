namespace Factory
{
    public class FiscalReceipt : FiscalDocument
    {
        private decimal _amount = 200;
        private string _type = "Fiscal Recipt";

        public override void PrintDocument()
        {
            Console.WriteLine($"My document is {_type} and value is {_amount}");
        }
    }
}
