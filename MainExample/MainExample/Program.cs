using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Collections.Generic;

namespace MainExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("We made a console app");
            Console.WriteLine(value: Product.GetSampleProducts()[0].ToString());
            Console.ReadKey();

        }
    }
}


public class Product
{
    readonly string name;
    public string Name { get { return name; } }
    readonly decimal price;
    public decimal Price { get { return price; } }
    public Product(string name, decimal price)
    {
        this.name = name;
        this.price = price;
    }
    public static List<Product> GetSampleProducts()
    {
        return new List<Product>
        {
            new Product(name: "West Side Story", price: 9.99m),
            new Product(name: "Assassins", price: 14.99m),
            new Product(name: "Frogs", price: 13.99m),
            new Product(name: "Sweeney Todd", price: 10.99m)
        };
    }
    public override string ToString()
    {
        return string.Format("{0}: {1}", name, price);
    }
}