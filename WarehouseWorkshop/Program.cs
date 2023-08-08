using WarehouseWorkshop;

var Apple =  new Item ("apples", "1");
var Pear =  new Item ("pears", "2");
var Lemon =  new Item ("lemons", "3");


// var Apples10 = new Stock (Apple, 10);
// var Pears20 = new Stock (Pear, 20);
// var Pears10 = new Stock (Pear, 10);
// var Lemons30 = new Stock (Lemon, 30);

var Apples2 = new Stock (Apple, 2);
var Pears1 = new Stock (Pear, 1);
var Lemons3 = new Stock (Lemon, 3);


var myPrices = new Prices();
var myBasket = new Basket(myPrices);

myBasket.AddItems(Pears1);
myBasket.AddItems(Apples2);
myBasket.AddItems(Lemons3);

Console.WriteLine(myBasket.ReportBasketContent());

Console.WriteLine($"Total Basket Price {myBasket.TotalPrice:C}\n");



// var myWarehouse = new Warehouse();

// myWarehouse.AddStock(Apples10);
// myWarehouse.AddStock(Pears20);
// myWarehouse.AddStock(Lemons30);

// Console.WriteLine(myWarehouse.ReportStockLevels());

// myWarehouse.RemoveStock(Pears10);
// // myWarehouse.RemoveStock(Pears20);

// Console.WriteLine(myWarehouse.ReportStockLevels());