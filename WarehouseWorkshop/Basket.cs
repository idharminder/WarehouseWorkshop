namespace WarehouseWorkshop;

public class Basket
{
  private Dictionary<string, int> Inventory { get; set; }

  public Basket(Dictionary<string, int> inventory)
  {
    Inventory = inventory;
  }
  public Basket()
  {
    Inventory = new Dictionary<string, int>();
  }

  public void AddItems(Stock stock)
  {
    if (Inventory.ContainsKey(stock.Name))
    {
      Inventory[stock.Name] += stock.Quantity;
    }
    else
    {
      Inventory.Add(stock.Name, stock.Quantity);
    }
  }

  public void RemoveItems(Stock stock)
  {
    if (Inventory.ContainsKey(stock.Name) && Inventory[stock.Name]>stock.Quantity)
    {
      Inventory[stock.Name] -= stock.Quantity;
    }
    else
    {
      throw new InvalidOperationException("Insufficient Items");
    }
  }

  public string ReportBasketContent(){
    string report = "Basket Contents\nItem\t\tQuantity\n";
    foreach (var item in Inventory)
    {
      report += $"\n{item.Key}\t\t{item.Value}";
    }
    return report+"\n";
  }
}