

using  System.Collections.Generic;

public class Product
{
    private readonly string name;
    public string Name
    {
        get { return name; }
    }

    private readonly decimal price;

    public decimal Price
    {
        get { return price; }
    }

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
            new Product(nameof: "Assassins", price: 14.99m)
        };
    }

    public override string ToString()
    {
        return string.Format("{0}: {1}", name, price);
    }

}


