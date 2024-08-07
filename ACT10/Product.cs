using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Product 
    {

    public string PhoneType()
    {
        string type = "Teléfono";
        return type;
    }
    public string PcType()
    {
        string type = "Teléfono";
        return type;
    }
    public string TabletType()
    {
        string type = "Teléfono";
        return type;
    }

    List<ProductType> newProduct = new List<ProductType>();

        public void AddProduct()
        {
            try
            {


                Console.WriteLine("Ingrese el ID del producto");
                string newId = Console.ReadLine();
                ProductType searchId = newProduct.Find(p => p.Id == newId);
                if (searchId != null)
                {
                    Console.WriteLine("El producto ya existe.");
                }
                else
                {
                    Console.WriteLine("Ingrese el nombre del producto:");
                    string name=Console.ReadLine();
                    Console.WriteLine("Ingrese el tipo de producto");
                    Console.WriteLine("\n1. Teléfono.");
                    Console.WriteLine("2. Ordenador.");
                    Console.WriteLine("3. Tablet.");
                    int typeOption=int.Parse(Console.ReadLine());
                    string type="";
                    switch (typeOption)
                    {
                        case 1:
                            type = PhoneType();
                            break;
                        case 2:
                            type=PcType();
                            break;
                        case 3:
                            type=TabletType();
                            break;
                        default:
                            Console.WriteLine("Elija una opción válida.");
                            break;
                    }
                    ProductType createProduct = new ProductType(newId,name, type);
                    newProduct.Add(createProduct);

                    Console.WriteLine("Producto ingresado correctamente.");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
        public void ShowAll()
        {
            foreach (ProductType product in newProduct) 
            {
                    Console.WriteLine($"ID: {product.Id}, nombre: {product.Name}, tipo de producto: {product.Type}");
            }
        }
        public void SearchProduct()
        {
            try
            {
                Console.WriteLine("Ingrese el ID del producto que desea buscar:");
                string searchProduct = Console.ReadLine();
                ProductType search = newProduct.Find(p => p.Id == searchProduct);
                if (search != null)
                {
                    Console.WriteLine("Nombre:"+ search.Name);
                    Console.WriteLine("Tipo de producto:"+search.Type);
                }
            }
            catch(Exception ex) { Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
       
    }

