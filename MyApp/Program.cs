using MyApp.Core;

var catalog = new ProductCatalog();
Console.WriteLine("""
Команди:
add,
remove,
list,
findname,
findindex,
exit,
""");
while (true)
{
   
    Console.Write("Команда: ");
    var command = Console.ReadLine();

    switch (command)
    {
        case "add":

            Console.Write("Iм'я продукту: ");

            var product = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(product))
            {
                catalog.Add(product);
            }

            break;

        case "remove":

            Console.Write("Iм'я продукту: ");

            var removeProduct = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(removeProduct))
            {
                if (catalog.Find(removeProduct) is null)
                {
                    Console.WriteLine("Товар не знайдено");
                    break;
                }
                else
                {
                    catalog.Remove(removeProduct);
                }
            }

            break;

        case "list":

            foreach (var item in catalog.GetAll())
            {
                Console.WriteLine(item);
            }

            break;

        case "findname":

            Console.Write("Iм'я продукту: ");

            var productName = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(productName))
            {
                var result = catalog.Find(productName);

                if (result is not null)
                {
                    Console.WriteLine($"Знайдено: {result}");
                }
                else
                {
                    Console.WriteLine("Товар не знайдено");
                }
            }

            break;

        case "findindex":

            Console.Write("Iндекс: ");

            if (int.TryParse(Console.ReadLine(), out int index))
            {
                var result = catalog.Find(index);

                if (result is not null)
                {
                    Console.WriteLine($"Знайдено: {result}");
                }
                else
                {
                    Console.WriteLine("Неправильний iндекс");
                }
            }
            else
            {
                Console.WriteLine("Iндекс повинен бути числом");
            }

            break;
        case "exit":
            return;

        default:
            Console.WriteLine("Незнайома команда");
            break;
    }
}