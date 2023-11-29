using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    /// <summary>
    /// Класс Person, который представляет человека
    /// </summary>
    class Person
    {
        /// <summary>
        /// Поле имени человека
        /// </summary>
        public string name;
        /// <summary>
        /// Поле фамилии человека
        /// </summary>
        public string surname;
        /// <summary>
        /// Поле возраста человека
        /// </summary>
        public int age;
        /// <summary>
        /// Метод, который выводит информацию о человеке
        /// </summary>
        public void Info()
        {
            Console.WriteLine($"Имя - {name}\tФамилия - {surname}\tВозраст - {age}");
        }
        //public string ToString()
        //{
        //    return $"Имя - {name}\tФамилия - {surname}\tВозраст - {age}";
        //}
        public override string ToString()
        {
            return $"Имя - {name}\tФамилия - {surname}\tВозраст - {age}";
        }


    }
}
