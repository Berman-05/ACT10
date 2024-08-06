using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT10
{
    public class Product
    {
        public string Id { get; set; }
        public string Type {  get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }      
        
        List<Product> newProduct= new List<Product>();

        public void AddProduct()
        {
            Console.WriteLine("Ingrese el ID del producto");
            string newId = Console.ReadLine();
        }
    }
}
