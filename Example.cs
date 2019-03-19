

using  System.Collections.Generic;

public class Product
{

    public string Name { get; private set; }
    public string Price { get; private set; }

    public Product(string name, decimal price)
    {

        Name = name;
        Price = price;

    }

    Product()
    {
    }

    public static List<Product> GetSampleProducts()
    {

        return new List<Product>
        {
            new Product {Name = "West Side Story", Price = 9.99m},
            new Product {Name = "Assassin", Price = 14.99m}
        };
    }

    public override string ToString()
    {
        return string.Format("{0}: {1}", Name, Price);
    }

}
