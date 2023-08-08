namespace WarehouseWorkshop;

public class Stock
{
  public string Name { get; set; }
  public int Quantity { get; set; }

  public Stock(string name, int quantity)
  {
    Name = name;
    Quantity = quantity;
  }
}