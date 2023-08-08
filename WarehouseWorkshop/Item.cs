namespace WarehouseWorkshop;

public class Item
{
    public string Name { get; set; }
    public string Id { get; set; }

    public Item(string name, string id)
    {
        Name = name;
        Id = id;
    }
}