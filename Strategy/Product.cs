internal class Product
{
  public string Name { get; set; }
  public ProductType ProductType { get; set; }
  public decimal Price { get; set; }
}

internal enum ProductType
{
    Standard,Premium
}