namespace WarehouseWorkshop;

public class Warehouse
{
    public List<Stock> Stocks { get; set; }

    public Warehouse(List<Stock> stocks)
    {
        Stocks = stocks;
    }

    public void AddStock(Stock stock)
    {
        if (Stocks.Exists(x => x.Item.Name == stock.Item.Name))
        {
            Stocks.Find(x => x.Item.Name == stock.Item.Name).Quantity += stock.Quantity;
        }
        else
        {
            Stocks.Add(stock);
        }
    }

    public string ReportInventory(){
        return "stub for inventory report";
    }


}