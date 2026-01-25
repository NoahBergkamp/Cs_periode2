namespace ProductenLaden;

using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.RunEigen();
    }


    private void RunProducten()
    {
             string text = File.ReadAllText("Producten.json");
        Product[] producten = JsonSerializer.Deserialize<Product[]>(text);

        foreach (Product product in producten)
        {
            Console.WriteLine(product.Name);
            Console.WriteLine(product.Description);
            Console.WriteLine(product.Price);
        }
   
    }

    private void Run()
    {
        string text = File.ReadAllText("Product.json");
        Product product = JsonSerializer.Deserialize<Product>(text);
        Console.WriteLine(product.Name);
        Console.WriteLine(product.Description);
        Console.WriteLine(product.Price);
    }

    private void RunEigen()
    {
        string text = File.ReadAllText("Product.json");
        Product product = JsonSerializer.Deserialize<Product>(text);
        Console.WriteLine(product.Name);
        Console.WriteLine(product.Description);
        Console.WriteLine(product.Price);
    }
}
