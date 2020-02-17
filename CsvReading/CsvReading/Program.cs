using System;
using System.IO;

namespace CsvReading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();


        }       
    }

    class auto
    {
        string _brand;
        string _name;
        int _year;
        int _distance;
        string _fuel;
        int _price;

        public auto(string brand, string name, int year, int distance, string fuel, int price)
        {
            _brand = brand;
            _name = name;
            _year = year;
            _distance = distance;
            _fuel = fuel;
            _price = price;
        }

        public string Brand { get => _brand; set => _brand = value; }
        public string Name { get => _name; set => _name = value; }
        public int Year { get => _year; set => _year = value; }
        public int Distance { get => _distance; set => _distance = value; }
        public string Fuel { get => _fuel; set => _fuel = value; }
        public int Price { get => _price; set => _price = value; }

    }
}
