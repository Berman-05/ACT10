using ACT10;
namespace ACT10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product createProduct = new Product();
            while (true)
            {
                try
                {
                    Console.Clear();
                    ShowMenu();
                    Console.WriteLine("");
                    int option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.Clear();
                            createProduct.AddProduct();
                            break;
                            case 2:
                            Console.Clear();
                            createProduct.ShowAll();
                            break;
                            case 3:
                            Console.Clear();
                            createProduct.SearchProduct();
                            break;
                            case 4:
                            return;
                        default:
                            Console.WriteLine("Elija una opción válida.");
                            break;
                    }
                    Console.ReadLine();
                } catch (Exception e) {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                }
            }
        }
        static void ShowMenu()
        {
            Console.WriteLine("Elija una opción");
            Console.WriteLine("\n1. Agregar producto.");
            Console.WriteLine("2. Mostrar todos los productos.");
            Console.WriteLine("3. Buscar un producto.");
            Console.WriteLine("4. Salir.");
        }
    }
}
