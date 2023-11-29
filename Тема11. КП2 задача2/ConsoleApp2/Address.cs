using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    /// <summary>
    /// Класс, описывающий адрес
    /// </summary>
    class Address
    {
        /// <summary>
        /// Поле индекса
        /// </summary>
        public ushort index;
        /// <summary>
        /// Поле названия страны
        /// </summary>
        public string country;
        /// <summary>
        /// Поле названия города
        /// </summary>
        public string city;
        /// <summary>
        /// Поле названия улицы
        /// </summary>
        public string street;
        /// <summary>
        /// Поле номера дома
        /// </summary>
        public ushort house;
        /// <summary>
        /// Поле номера квартиры
        /// </summary>
        public ushort apartament;
        /// <summary>
        /// Метод вывода информации об адресе
        /// </summary>
        /// <returns>индекс, страна, город, улица, дом, квартира</returns>
        public override string ToString()
        {
            return $"{index}\t{country}\t{city}\t{street}\t{house}\t{apartament}";
        }




    }
}
