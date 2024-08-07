using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class ProductType
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
    
    public ProductType(string id, string type, string name)
        {
            Id = id;
            Type = type;
            Name = name;
        }
    }

