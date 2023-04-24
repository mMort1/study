using System;

namespace ProgramProducts
{
    enum AccountingSystems
    {
        System1,
        System2,
        System3
    }

    enum LogisticsSystems
    {
        System4,
        System5,
        System6
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Список програмних продуктiв:");
            Console.WriteLine("0 - Система облiку 1");
            Console.WriteLine("1 - Система облiку 2");
            Console.WriteLine("2 - Система облiку 3");
            Console.WriteLine("3 - Система управлiння логiстикою 1");
            Console.WriteLine("4 - Система управлiння логiстикою 2");
            Console.WriteLine("5 - Система управлiння логiстикою 3");

            Console.Write("Введiть номери програмних продуктiв, якi ви хочете придбати (вiдокремте номери комами): ");
            string input = Console.ReadLine();
            string[] selectedProducts = input.Split(',');
            Console.WriteLine();

            Console.WriteLine("Прiзвище автора програми: Усатюк");

            Console.WriteLine("Програмнi продукти для автоматизацiї облiку:");
            foreach (string product in selectedProducts)
            {
                if (Enum.TryParse<AccountingSystems>(product, out AccountingSystems accountingSystem))
                {
                    switch (accountingSystem)
                    {
                        case AccountingSystems.System1:
                            Console.WriteLine("Система облiку 1");
                            break;
                        case AccountingSystems.System2:
                            Console.WriteLine("Система облiку 2");
                            break;
                        case AccountingSystems.System3:
                            Console.WriteLine("Система облiку 3");
                            break;
                        default:
                            break;
                    }
                }
            }

            Console.WriteLine("Програмнi продукти для управлiння логiстикою:");
            foreach (string product in selectedProducts)
            {
                if (Enum.TryParse<LogisticsSystems>(product, out LogisticsSystems logisticsSystem))
                {
                    switch (logisticsSystem)
                    {
                        case LogisticsSystems.System4:
                            Console.WriteLine("Система управлiння логiстикою 1");
                            break;
                        case LogisticsSystems.System5:
                            Console.WriteLine("Система управлiння логiстикою 2");
                            break;
                        case LogisticsSystems.System6:
                            Console.WriteLine("Система управлiння логiстикою 3");
                            break;
                        default:
                            break;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
