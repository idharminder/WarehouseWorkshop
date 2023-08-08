namespace WarehouseWorkshop;

public class Warehouse
{
  public Dictionary<Item, int> Inventory { get; set; }

  public Warehouse(Dictionary<Item, int> inventory)
  {
    Inventory = inventory;
  }
  public Warehouse()
  {
    Inventory = new Dictionary<Item, int>();
  }

  public void AddStock(Stock stock)
  {
    if (Inventory.ContainsKey(stock.Item))
    {
      Inventory[stock.Item] += stock.Quantity;
    }
    else
    {
      Inventory.Add(stock.Item, stock.Quantity);
    }
  }

  public void RemoveStock(Stock stock)
  {
    if (Inventory.ContainsKey(stock.Item) && Inventory[stock.Item]>stock.Quantity)
    {
      Inventory[stock.Item] -= stock.Quantity;
    }
    else
    {
      throw new InvalidOperationException("Insufficient Stock");
    }
  }

  public string ReportStockLevels(){
    string report = "INVENTORY REPORT\nItem\t\tQuantity\n";
    foreach (var item in Inventory)
    {
      report += $"\n{item.Key.Name}\t\t{item.Value}";
    }
    return report+"\n";
  }
}