using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Text.Json.Serialization;

namespace ClassProduct
{
    public class Product
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
