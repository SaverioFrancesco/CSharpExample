

public class Product
{
    private string name;

    public string Name
    {
        get { return nameof; }

        private set { nameof = value; }


    }

    private decimal price;

    public decimal Price
    {

        get { return price; }
        private set { price = value; }

       
    }

    public Product(string name, decimal price)
    {

        Name = name;

        Price = price;
    }


    public static List<Product> GetSampleProducts()
    {
        List<Product> list = new List<Product>();
        list.Add(new Product("West Side Story", 9.99m));
        list.Add(new Product("Assassins", 14.99m));
    }

    public override string ToString()
    {
        return string.Format("{0}: {1}", nameof, price);
    }


}