enum SoftwareProduct
{
    AccountingSystem1,
    AccountingSystem2,
    AccountingSystem3,
    LogisticsSystem1,
    LogisticsSystem2,
    LogisticsSystem3
}

static void Main(string[] args)
{
    Console.WriteLine("Перелік систем:");
    Console.WriteLine($"{(int)SoftwareProduct.AccountingSystem1} - Система обліку 1");
    Console.WriteLine($"{(int)SoftwareProduct.AccountingSystem2} - Система обліку 2");
    Console.WriteLine($"{(int)SoftwareProduct.AccountingSystem3} - Система обліку 3");
    Console.WriteLine($"{(int)SoftwareProduct.LogisticsSystem1} - Система управління логістикою 1");
    Console.WriteLine($"{(int)SoftwareProduct.LogisticsSystem2} - Система управління логістикою 2");
    Console.WriteLine($"{(int)SoftwareProduct.LogisticsSystem3} - Система управління логістикою 3");

    Console.WriteLine("Введіть номери програмних продуктів, які ви хочете придбати (відокремлюючи номери комами):");
    string input = Console.ReadLine();

    string[] productNumbers = input.Split(',');
    List<SoftwareProduct> selectedProducts = new List<SoftwareProduct>();

    foreach (string number in productNumbers)
    {
        if (Enum.IsDefined(typeof(SoftwareProduct), int.Parse(number)))
        {
            selectedProducts.Add((SoftwareProduct)int.Parse(number));
        }
    }

    Console.WriteLine("Прізвище автора програми: [Введіть своє прізвище]");

    Console.WriteLine("Список програмних продуктів з групи обліку:");
    foreach (SoftwareProduct product in selectedProducts)
    {
        if (product == SoftwareProduct.AccountingSystem1 ||
            product == SoftwareProduct.AccountingSystem2 ||
            product == SoftwareProduct.AccountingSystem3)
        {
            Console.WriteLine(product.ToString());
        }
    }

    Console.WriteLine("Список програмних продуктів з групи логістики:");
    foreach (SoftwareProduct product in selectedProducts)
    {
        if (product == SoftwareProduct.LogisticsSystem1 ||
            product == SoftwareProduct.LogisticsSystem2 ||
            product == SoftwareProduct.LogisticsSystem3)
        {
            Console.WriteLine(product.ToString());
        }
    }

    Console.ReadLine();
}

