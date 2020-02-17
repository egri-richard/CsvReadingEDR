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

    }
}
