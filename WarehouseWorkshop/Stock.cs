namespace WarehouseWorkshop;

public class Stock
{
    public Item Item { get; set; }
    public int Quantity { get; set; }

    public Stock(Item item,int quantity)
    {
        Item = item;
        Quantity = quantity;
    }
}
