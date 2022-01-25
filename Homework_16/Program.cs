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

namespace Homework_16
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/marve/YandexDisk/Autodesk_ITMO_2021/1-CSharp/Homework_16/Homework_16/bin/Debug/Products.json";
            Product[] products = new Product[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите поочередно с новой строчки код, название и цену продукта");
                products[i] = new Product()
                {
                    ProductCode = Convert.ToInt32(Console.ReadLine()),
                    ProductName = Convert.ToString(Console.ReadLine()),
                    ProductPrice = Convert.ToDouble(Console.ReadLine())
                };
            }
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(products, options);
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(jsonString);
            }
        }
        class Product
        {
            public int ProductCode { get; set; }
            public string ProductName { get; set; }
            public double ProductPrice { get; set; }
        }
    }
}
