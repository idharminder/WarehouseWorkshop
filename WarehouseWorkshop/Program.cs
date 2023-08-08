using WarehouseWorkshop;

Console.WriteLine("HelloWorld");

var Apple =  new Item ("apples", 0.35m);
var Pear =  new Item ("pears", 0.25m);
var Lemon =  new Item ("lemons", 0.15m);


var Apples10 = new Stock (Apple.Name, 10);
var Pears20 = new Stock (Pear.Name, 20);
var Pears10 = new Stock (Pear.Name, 10);
var Lemons30 = new Stock (Lemon.Name, 30);

var myWarehouse = new Warehouse();

myWarehouse.AddStock(Apples10);
myWarehouse.AddStock(Pears20);
myWarehouse.AddStock(Lemons30);

Console.WriteLine(myWarehouse.ReportStockLevels());

myWarehouse.RemoveStock(Pears10);
// myWarehouse.RemoveStock(Pears20);

Console.WriteLine(myWarehouse.ReportStockLevels());