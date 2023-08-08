namespace WarehouseWorkshop;

public class Basket
{
  public Dictionary<Item, int> Contents { get; set; }
  public Prices Prices { get; set; }

  public Warehouse Warehouse  { get; set; }
  public decimal TotalPrice { 
    get{
      return Contents.Sum(x => Prices.PriceList[x.Key.Id] * x.Value);
    }
  }
  public Basket(Prices prices, Warehouse warehouse)
  {
    this.Prices = prices;
    this.Warehouse = warehouse; 
    Contents = new Dictionary<Item, int>();
  }

  public void AddItems(Stock stock)
  {
    Warehouse.RemoveStock(stock);
    if (Contents.ContainsKey(stock.Item))
    {
      Contents[stock.Item] += stock.Quantity;
    }
    else
    {
      Contents.Add(stock.Item, stock.Quantity);
    }
  }

  public void RemoveItems(Stock stock)
  {
    if (Contents.ContainsKey(stock.Item) && Contents[stock.Item]>stock.Quantity)
    {
      Contents[stock.Item] -= stock.Quantity;
    }
    else
    {
      throw new InvalidOperationException("Insufficient Items");
    }
    Warehouse.AddStock(stock);

  }

  public string ReportBasketContent(){
    string report = "\nBasket Contents\nItem\t\tQuantity\tUnit Price\n";
    foreach (var item in Contents)
    {
      report += $"\n{item.Key.Name}\t\t{item.Value}\t\t{Prices.PriceList[item.Key.Id]:C}";
    }
    return report+"\n";
  }
}