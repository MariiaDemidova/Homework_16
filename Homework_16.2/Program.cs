using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Text.Json.Serialization;

namespace Homework_16._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/marve/YandexDisk/Autodesk_ITMO_2021/1-CSharp/Homework_16/Homework_16/bin/Debug/Products.json";
            string jsonString = File.ReadAllText(path);
            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);
            double max = products[0].ProductPrice;
            string expensive = products[0].ProductName;
            for (int i = 1; i < 5; i++)
            {
                if (products[i].ProductPrice > max)
                {
                    max = products[i].ProductPrice;
                    expensive = products[i].ProductName;
                }
            }
            Console.WriteLine("Самый дорогой товар - {0}", expensive);
            Console.ReadKey();
        }
    }
    class Product
    {
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
    }
}
