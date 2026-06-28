using MyApp.Core;
using MyApp.Core.DTOs;
using MyApp.Core.Entities;
using MyApp.Core.Mapper;
using System.Text.RegularExpressions;

//var catalog = new ProductCatalog();
//Console.WriteLine("""
//Команди:
//add,
//remove,
//list,
//findname,
//findindex,
//exit,
//""");
//while (true)
//{

//    Console.Write("Команда: ");
//    var command = Console.ReadLine();

//    switch (command)
//    {
//        case "add":

//            Console.Write("Iм'я продукту: ");

//            var product = Console.ReadLine();

//            if (!string.IsNullOrWhiteSpace(product))
//            {
//                catalog.Add(product);
//            }

//            break;

//        case "remove":

//            Console.Write("Iм'я продукту: ");

//            var removeProduct = Console.ReadLine();

//            if (!string.IsNullOrWhiteSpace(removeProduct))
//            {
//                if (catalog.Find(removeProduct) is null)
//                {
//                    Console.WriteLine("Товар не знайдено");
//                    break;
//                }
//                else
//                {
//                    catalog.Remove(removeProduct);
//                }
//            }

//            break;

//        case "list":

//            foreach (var item in catalog.GetAll())
//            {
//                Console.WriteLine(item);
//            }

//            break;

//        case "findname":

//            Console.Write("Iм'я продукту: ");

//            var productName = Console.ReadLine();

//            if (!string.IsNullOrWhiteSpace(productName))
//            {
//                var result = catalog.Find(productName);

//                if (result is not null)
//                {
//                    Console.WriteLine($"Знайдено: {result}");
//                }
//                else
//                {
//                    Console.WriteLine("Товар не знайдено");
//                }
//            }

//            break;

//        case "findindex":

//            Console.Write("Iндекс: ");

//            if (int.TryParse(Console.ReadLine(), out int index))
//            {
//                var result = catalog.Find(index);

//                if (result is not null)
//                {
//                    Console.WriteLine($"Знайдено: {result}");
//                }
//                else
//                {
//                    Console.WriteLine("Неправильний iндекс");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Iндекс повинен бути числом");
//            }

//            break;
//        case "exit":
//            return;

//        default:
//            Console.WriteLine("Незнайома команда");
//            break;
//    }
//}

//Завдання 3
//string text = "apple banana apple cherry banana apple";
//var res = text.Split(' ')
//    .GroupBy(x => x)
//    .ToDictionary(g => g.Key, g => g.Count())
//    .OrderByDescending(x => x.Value);

//foreach (var x in res)
//    Console.WriteLine($"{x.Key}={x.Value}");

////Завдання 4
//var hash1 = new HashSet<string> { "Stepan", "Andrii", "Serhiy", "Vasil" };
//var hash2 = new HashSet<string> { "Andrii", "Serhiy", "Katya", "Alina" };

//var both = new HashSet<string>(hash1);
//both.IntersectWith(hash2);

//Console.WriteLine("In both groups:");
//foreach (var s in both)
//    Console.WriteLine(s);

//var onlyFirst = new HashSet<string>(hash1);
//onlyFirst.ExceptWith(hash2);

//Console.WriteLine("Only in first group:");
//foreach (var s in onlyFirst)
//    Console.WriteLine(s);

//var all = new HashSet<string>(hash1);
//all.UnionWith(hash2);

//Console.WriteLine("All unique students:");
//foreach (var s in all)
//    Console.WriteLine(s);

////Завдання 5
//Console.WriteLine("Task 5");

//int a = 5;
//int b = 10;

//Generics.Swap(ref a, ref b);

//Console.WriteLine($"{a} {b} \n");


////Завдання 6
//Console.WriteLine("Task 6");


//var stack = new MyStack<int>();

//stack.Push(10);
//stack.Push(20);

//Console.WriteLine(stack.Peek());
//Console.WriteLine(stack.Pop());
//Console.WriteLine(stack.Pop());

//////Завдання 7
/////
//var students = new List<Student>
//{
//    new("Олег",  85),
//    new("Юля",   92),
//    new("Влад",  78),
//    new("Аня",   92),
//    new("Петро", 65),
//};

//var more80 = students.Where(v => v.Grade > 80);
//var ordered = students.OrderByDescending(o => o.Grade).Select(o => o.Name);
//var serednie = students.Average(s => s.Grade);
//var highest = students.OrderBy(s => s.Grade).Last(); // or students.MaxBy(s => s.Grade); or students.OrderByDescending(s => s.Grade).First();
//var grouped = students.OrderByDescending(s => s.Grade).GroupBy(s => s.Grade).ToDictionary(g => g.Key, g => g.Select(x => x.Name).ToList());
//Console.WriteLine(highest);

//foreach (var student in ordered)
//{
//    //Console.WriteLine($"{student.Name}: {student.Grade}");
//    Console.WriteLine(student);

//}
//foreach (var group in grouped)
//{
//    Console.WriteLine($"{group.Key}: {string.Join(", ", group.Value)}");
//}
//Console.WriteLine();


//////Завдання 8
//var numbers = new List<int> { 1, 2, 3, 4, 5 };
//var query = numbers.Where(x => x > 2).ToList();
//numbers.Add(6);
//numbers.Add(7);
//foreach (var n in query)
//    Console.WriteLine(n);


//record Student(string Name, int Grade);

var rawProducts = new List<RawProduct>
{
    new() { Id = 1,  Name = "Laptop",      CategoryName = "Electronics", PriceUsd = 999.99, StockCount = 5,  IsActive = true  },
    new() { Id = 2,  Name = "Phone",       CategoryName = "Electronics", PriceUsd = 499.99, StockCount = 12, IsActive = true  },
    new() { Id = 3,  Name = "Headphones",  CategoryName = "Electronics", PriceUsd = 79.99,  StockCount = 0,  IsActive = true  },
    new() { Id = 4,  Name = "T-Shirt",     CategoryName = "Clothing",    PriceUsd = 19.99,  StockCount = 50, IsActive = true  },
    new() { Id = 5,  Name = "Jeans",       CategoryName = "Clothing",    PriceUsd = 49.99,  StockCount = 30, IsActive = false },
    new() { Id = 6,  Name = "Coffee Maker",CategoryName = "Kitchen",     PriceUsd = 89.99,  StockCount = 8,  IsActive = true  },
    new() { Id = 7,  Name = "Blender",     CategoryName = "Kitchen",     PriceUsd = 39.99,  StockCount = 0,  IsActive = true  },
    new() { Id = 8,  Name = "Desk Lamp",   CategoryName = "Office",      PriceUsd = 24.99,  StockCount = 20, IsActive = true  },
};

var rawOrders = new List<RawOrder>
{
    new() { OrderId = 101, CustomerId = 1, CustomerName = "Alice",   ProductIds = new() { 1, 3 },    Status = "shipped",   CreatedAt = new DateTime(2024, 1, 10) },
    new() { OrderId = 102, CustomerId = 2, CustomerName = "Bob",     ProductIds = new() { 2, 4, 6 }, Status = "pending",   CreatedAt = new DateTime(2024, 2, 5)  },
    new() { OrderId = 103, CustomerId = 1, CustomerName = "Alice",   ProductIds = new() { 5 },       Status = "cancelled", CreatedAt = new DateTime(2024, 2, 20) },
    new() { OrderId = 104, CustomerId = 3, CustomerName = "Charlie", ProductIds = new() { 1, 2 },    Status = "shipped",   CreatedAt = new DateTime(2024, 3, 1)  },
    new() { OrderId = 105, CustomerId = 2, CustomerName = "Bob",     ProductIds = new() { 8 },       Status = "pending",   CreatedAt = new DateTime(2024, 3, 15) },
};

var products = ProductMapper.ToDtoList(rawProducts);
var orders = OrderMapper.ToDtoList(rawOrders);


var availableProd = products.Where(p => p.IsAvailable).OrderBy(p => p.Price);
Console.WriteLine("Available Products:");
foreach (var pr in availableProd)
    Console.WriteLine(pr.Name + ": " + pr.Price);

var productsElectronics = products.Where(e => e.Category == "Electronics" && e.Price < 500);
Console.WriteLine("\nElectronics Products under $500:");
foreach (var pr in productsElectronics)
    Console.WriteLine(pr.Name + ": " + pr.Price);

var categoryAvg = products.GroupBy(a => a.Category).ToDictionary(p => p.Key, p => p.Average(x => x.Price));

Console.WriteLine("\nAverage Prices by Category:");
foreach (var kvp in categoryAvg)
    Console.WriteLine($"{kvp.Key}: ${kvp.Value:F2}");

var expenciveInCategory = products.GroupBy(e => e.Category).ToDictionary(g => g.Key, g => g.MaxBy(e => e.Price));

Console.WriteLine("\nMost Expensive Product in Each Category:");
foreach (var pr in expenciveInCategory)
    Console.WriteLine($"{pr.Key}: {pr.Value!.Name} - ${pr.Value.Price}");

Console.WriteLine("\nUnAvailable Products:");

var unave = products.Where(u => !u.IsAvailable);
foreach (var pr in unave)
    Console.WriteLine(pr.Name + ": " + pr.Price);


//orders

var shiip = orders.Where(s => s.Status == OrderStatus.Shipped).OrderBy(s => s.CreatedAt);
Console.WriteLine("\nShipped Orders:");
foreach (var o in shiip)
    Console.WriteLine($"Order ID: {o.OrderId}, Customer: {o.CustomerName}, Created At: {o.CreatedAt}");

var byStatys = orders.GroupBy(b => b.Status).ToDictionary(g => g.Key, g => g.Count());
Console.WriteLine("\nOrders by Status:");
foreach (var o in byStatys)
    Console.WriteLine($"{o.Key}: {o.Value}");

var id1 = orders.Where(i => i.ProductIds.Contains(1));
Console.WriteLine("\nWhere Ids 1:");
foreach (var o in id1)
    Console.WriteLine($"Order ID: {o.OrderId}, Customer: {o.CustomerName}, Created At: {o.CreatedAt}");

var cancelled = orders.Where(c => c.Status == OrderStatus.Cancelled).Select(c => c.CustomerId);
Console.WriteLine("\nCancelled Orders:");
foreach (var o in cancelled)
    Console.WriteLine($"Customer id: {o}");