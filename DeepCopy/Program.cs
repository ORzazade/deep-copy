using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product();
            product.Id = 1;
            product.Name = "orxan";
            product.dic = new Dictionary<string, string>();
            product.dic.Add("TestKey", "TestValue");
            Console.WriteLine("Source: "+ JsonConvert.SerializeObject(product));
            var copiedProduct = new Product().CopyFrom(product);
            product.Id = 2;
            Console.WriteLine("Result: "+ JsonConvert.SerializeObject(copiedProduct));
            Console.ReadLine();
        }
    }
}
