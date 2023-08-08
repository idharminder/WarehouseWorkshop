using WarehouseWorkshop;

var Apple =  new Item ("apples", "1");
var Pear =  new Item ("pears", "2");
var Lemon =  new Item ("lemons", "3");


var ApplesPallet100 = new Stock (Apple, 100);
var PearsPallet200 = new Stock (Pear, 200);
var LemonsPallet300 = new Stock (Lemon, 300);

var ApplesSelected1 = new Stock (Apple, 1);
var PearsSelected2 = new Stock (Pear, 2);
var LemonsSelected3 = new Stock (Lemon, 3);


var myWarehouse = new Warehouse();
var myPrices = new Prices();
var myBasket = new Basket(myPrices, myWarehouse);


myWarehouse.AddStock(ApplesPallet100);
myWarehouse.AddStock(PearsPallet200);
myWarehouse.AddStock(LemonsPallet300);

Console.WriteLine(myWarehouse.ReportStockLevels());

myBasket.AddItems(ApplesSelected1);
myBasket.AddItems(PearsSelected2);
myBasket.AddItems(LemonsSelected3);

Console.WriteLine(myBasket.ReportBasketContent());
Console.WriteLine($"Total Basket Price {myBasket.TotalPrice:C}\n");

Console.WriteLine(myWarehouse.ReportStockLevels());
