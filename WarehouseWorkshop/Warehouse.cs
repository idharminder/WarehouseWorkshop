namespace WarehouseWorkshop;

public class Warehouse
{
  private Dictionary<string, int> Inventory { get; set; }

  public Warehouse(Dictionary<string, int> inventory)
  {
    Inventory = inventory;
  }
  public Warehouse()
  {
    Inventory = new Dictionary<string, int>();
  }

  public void AddStock(Stock stock)
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

  public void RemoveStock(Stock stock)
  {
    if (Inventory.ContainsKey(stock.Name) && Inventory[stock.Name]>stock.Quantity)
    {
      Inventory[stock.Name] -= stock.Quantity;
    }
    else
    {
      throw new InvalidOperationException("Insufficient Stock");
    }
  }

  public string ReportStockLevels(){
    string report = "Item\t\tQuantity\n";
    foreach (var item in Inventory)
    {
      report += $"\n{item.Key}\t\t{item.Value}";
    }
    return report+"\n";
  }
}