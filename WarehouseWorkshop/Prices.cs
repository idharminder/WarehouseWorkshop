namespace WarehouseWorkshop;

public class Prices
{
  public Dictionary<string, decimal> PriceList { get; set; }

  public Prices()
  {
        PriceList = new Dictionary<string, decimal>
        {
            { "1", 0.35m },
            { "2", 0.45m },
            { "3", 0.55m }
        };
    }
}