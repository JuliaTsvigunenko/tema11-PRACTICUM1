using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.index = 3300;
            address.country = "Молдова";
            address.city = "Кишинев";
            address.street = "Восточная";
            address.house = 5;
            address.apartament = 28;

            Console.WriteLine($"{address.ToString()}");
            Console.Read();
        }
    }
}
