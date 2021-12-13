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
            string path = "C:/Users/marve/YandexDisk/Autodesk_ITMO_2021/1-CSharp/Homework_16/Products.json";
            string jsonString = File.ReadAllText(path);
            Product products = JsonSerializer.Deserialize<Product>(jsonString);
            Console.WriteLine("Код продукта: {0}", products.ProductCode);
            Console.WriteLine("Наименование продукта: {0}", products.ProductName);
            Console.WriteLine("Цена продукта: {0}", products.ProductPrice);
            Console.ReadKey();
        }
    }
    class Product
    {
        [JsonPropertyName("Код продукта")]
        public int ProductCode { get; set; }
        [JsonPropertyName("Наименование продукта")]
        public string ProductName { get; set; }
        [JsonPropertyName("Цена продукта")]
        public double ProductPrice { get; set; }

        public Product(int code, string name, double price)
        {
            ProductCode = code;
            ProductName = name;
            ProductPrice = price;
        }
    }
}
