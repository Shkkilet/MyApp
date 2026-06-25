using MyApp.Core;
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
string text = "apple banana apple cherry banana apple";
var res = text.Split(' ')
    .GroupBy(x => x)
    .ToDictionary(g => g.Key, g => g.Count())
    .OrderByDescending(x => x.Value);

foreach (var x in res)
    Console.WriteLine($"{x.Key}={x.Value}");

//Завдання 4
var hash1 = new HashSet<string> { "Stepan", "Andrii", "Serhiy", "Vasil" };
var hash2 = new HashSet<string> { "Andrii", "Serhiy", "Katya", "Alina" };

var both = new HashSet<string>(hash1);
both.IntersectWith(hash2);

Console.WriteLine("In both groups:");
foreach (var s in both)
    Console.WriteLine(s);

var onlyFirst = new HashSet<string>(hash1);
onlyFirst.ExceptWith(hash2);

Console.WriteLine("Only in first group:");
foreach (var s in onlyFirst)
    Console.WriteLine(s);

var all = new HashSet<string>(hash1);
all.UnionWith(hash2);

Console.WriteLine("All unique students:");
foreach (var s in all)
    Console.WriteLine(s);

//Завдання 5
Console.WriteLine("Task 5");

int a = 5;
int b = 10;

Generics.Swap(ref a, ref b);

Console.WriteLine($"{a} {b} \n");


//Завдання 6
Console.WriteLine("Task 6");


var stack = new MyStack<int>();

stack.Push(10);
stack.Push(20);

Console.WriteLine(stack.Peek());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());

////Завдання 7
///
var students = new List<Student>
{
    new("Олег",  85),
    new("Юля",   92),
    new("Влад",  78),
    new("Аня",   92),
    new("Петро", 65),
};

var more80 = students.Where(v => v.Grade > 80);
var ordered = students.OrderByDescending(o => o.Grade).Select(o => o.Name);
var serednie = students.Average(s => s.Grade);
var highest = students.OrderBy(s => s.Grade).Last(); // or students.MaxBy(s => s.Grade); or students.OrderByDescending(s => s.Grade).First();
var grouped = students.OrderByDescending(s => s.Grade).GroupBy(s => s.Grade).ToDictionary(g => g.Key, g => g.Select(x => x.Name).ToList());
Console.WriteLine(highest);

foreach (var student in ordered)
{
    //Console.WriteLine($"{student.Name}: {student.Grade}");
    Console.WriteLine(student);

}
foreach (var group in grouped)
{
    Console.WriteLine($"{group.Key}: {string.Join(", ", group.Value)}");
}
Console.WriteLine();


////Завдання 8
var numbers = new List<int> { 1, 2, 3, 4, 5 };
var query = numbers.Where(x => x > 2).ToList();
numbers.Add(6);
numbers.Add(7);
foreach (var n in query)
    Console.WriteLine(n);


record Student(string Name, int Grade);

