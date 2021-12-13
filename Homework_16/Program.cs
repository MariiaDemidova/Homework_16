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
            string path = "C:/Users/marve/YandexDisk/Autodesk_ITMO_2021/1-CSharp/Homework_16/Products.json";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            Product[] products = new Product[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите поочередно с новой строчки код, название и цену продукта");
                products [i] = new Product(Convert.ToInt32(Console.ReadLine()), Convert.ToString(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                //JsonSerializerOptions options = new JsonSerializerOptions()
                //{
                   // Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                   // WriteIndented = true
                //};
               // string jsonString = JsonSerializer.Serialize<Product>(products[i], options);
                //using (StreamWriter sw = new StreamWriter(path, true))
                //{
                 //   sw.WriteLine(jsonString);
                //}
            }
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize<Product>(products, options);
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(jsonString);
            }
            Console.ReadKey();
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
}
