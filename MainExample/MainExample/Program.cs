using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Xml.Linq;

namespace MainExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("We made a console app");

            List<Product> products = Product.GetSampleProducts();
            List<Supplier> suppliers = Supplier.GetSampleSuppliers();

            foreach (Supplier suplier in suppliers.Where(p => p.Name != null))
            {
                Console.WriteLine(suplier.Name);
            }

            XDocument doc = XDocument.Load("C:\\Users\\francescosaverio.com\\Desktop\\Csharp\\CSharpExample\\MainExample\\MainExample\\data.xml");
         

         var filtered = from p in doc.Descendants("Product")
                join s in doc.Descendants("Supplier")
                    on (int)p.Attribute("SupplierID")
                    equals (int)s.Attribute("SupplierID")
                where (decimal)p.Attribute("Price") > 10
                orderby (string)s.Attribute("Name"),
                    (string)p.Attribute("Name")
                select new
                {
                    SupplierName = (string)s.Attribute("Name"),
                    ProductName = (string)p.Attribute("Name")
                };
            foreach (var v in filtered)
            {
                Console.WriteLine("Supplier={0}; Product={1}",
                    v.SupplierName, v.ProductName);
            }

            Console.WriteLine("LINQ end displaying");

            Console.ReadKey();
            filtered = from p in products
                join s in suppliers
                    on p.SupplierID equals s.SupplierID
                       where p.Price > 10
                orderby s.Name, p.Name
                select new { SupplierName = s.Name, ProductName = p.Name };
            foreach (var v in filtered)
            {
                Console.WriteLine("Supplier={0}; Product={1}",
                    v.SupplierName, v.ProductName);
            }

            Console.ReadKey();
            
        }
    }
}

public class Supplier
{
    public static List<Supplier> GetSampleSuppliers()
    {
        return new List<Supplier>
        {
            new Supplier(name: "Bean", id: 0),
            new Supplier(name: "MiriExpress", id: 1),

        };

    }

    public Supplier(string name, int id)
    {
        this.name = name;
        this.suplierid = id;
    }

    readonly string name;
    public string Name { get { return name; } }
    readonly decimal? suplierid;

    public decimal? SupplierID { get { return suplierid; } }
}

public class Product
{
    readonly string name;
    public string Name { get { return name; } }
    readonly decimal? price;
    public decimal? Price { get { return price; } }
    readonly decimal? supplierid;
    public decimal? SupplierID { get { return supplierid; } }

    public Product(string name, decimal? supplierid, decimal? price = null)
    {
        this.name = name;
        this.supplierid = supplierid;
        this.price = price;
    }
    public static List<Product> GetSampleProducts()
    {
        return new List<Product>
        {
            new Product(name: "West Side Story", supplierid:0 , price: 9.99m),
            new Product(name: "Assassins", supplierid:0, price: 04.99m),
            new Product(name: "Frogs", supplierid:0 ,  price: 13.99m),
            new Product(name: "Sweeney Todd" , supplierid:0, price: 19.99m),
            new Product(name: "Esteldor" , supplierid:0, price: 10.99m)
        };
    }
    public override string ToString()
    {
        return string.Format("<{2}> {0}: {1}", name, price, supplierid);
    }
}