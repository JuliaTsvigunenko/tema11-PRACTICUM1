using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            //Person person;
            //person new Person();
            person.name = "Юлия";
            person.surname = "Цвигуненко";
            person.age = 17;
            person.Info();

            Person person1 = new Person();
            person1.name = "Елизавета";
            person1.surname = "Доброва";
            person1.age = 18;
            Console.WriteLine($"{person1.ToString()}");
            
            Person person2 = new Person();
            person2.name = "Александра";
            person2.surname = "Соловьева";
            person2.age = 19;
            Console.WriteLine($"{person2.ToString()}");
            
            Console.Read();


        }
    }
}
