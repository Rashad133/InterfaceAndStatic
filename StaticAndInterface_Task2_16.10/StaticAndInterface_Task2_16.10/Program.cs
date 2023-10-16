using StaticAndInterface_Task2_16._10.Extensions;

namespace StaticAndInterface_Task2_16._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eded daxil et");
            int num1 = int.Parse(Console.ReadLine());
            if (num1.IsOdd())
            {
                Console.WriteLine($"{num1} tek ededdir");
            }
            else
            {
                Console.WriteLine($"{num1} cut ededdir");
            }

            Console.WriteLine("Eded daxil edin");
            int num2 = int.Parse(Console.ReadLine());

            if (num2.IsOdd())
            {
                Console.WriteLine($"{num2} cut ededdir");
            }
            else
            {
                Console.WriteLine($"{num2} tek ededdir");
            }

            Console.WriteLine("Parol daxil edin");
            string password = Console.ReadLine();

            if (password.CheckPassword())
            {
                Console.WriteLine($"Parol duzdu");
            }
            else
            {
                Console.WriteLine($"Parol duzgun deyil");
            }
        }
    }
}