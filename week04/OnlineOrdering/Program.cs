using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        //Dictionary of addresses
        Dictionary<int, Address> addressesPorId = new Dictionary<int, Address>();
        addressesPorId.Add(1, new Address("278 North Blossom Lane", "New York", "NY", "USA"));
        addressesPorId.Add(2, new Address("La marina 345", "Lima", "PE", "PERU"));

        //Dictionary of customers
        Dictionary<int, Customer> customersPorId = new Dictionary<int, Customer>();
        customersPorId.Add(1, new Customer("Deborah Rockwell", addressesPorId[1]));
        customersPorId.Add(2, new Customer("Pedro Lopez", addressesPorId[2]));

        //Dictionary of products
        Dictionary<int, Product> productsPorId = new Dictionary<int, Product>();
        productsPorId.Add(11, new Product("Clock", 1001, 25.00, 2));
        productsPorId.Add(12, new Product("Computer", 1002, 5000.00, 1));
        productsPorId.Add(21, new Product("Phone", 1003, 1200.00, 1));
        productsPorId.Add(22, new Product("Table", 1004, 150.00, 1));
        productsPorId.Add(23, new Product("Chair", 1005, 50.00, 4));

        //Orderes
        Order orderUSA = new Order(customersPorId[1]);
        Order orderPERU = new Order(customersPorId[2]);
        foreach (var prod in productsPorId)
        {
            if (prod.Key.ToString().Substring(0, 1) == "1")
            {
                Product product = productsPorId[prod.Key];
                orderUSA.AddProduct(product);
            }

            if (prod.Key.ToString().Substring(0, 1) == "2")
            {
                Product product = productsPorId[prod.Key];
                orderPERU.AddProduct(product);
            }
        }

        //Display Order information
        Console.WriteLine("Welcome to the Online Ordering Program.\n");
        orderUSA.GetDisplayOrder(orderUSA,"Order USA");
        orderPERU.GetDisplayOrder(orderPERU, "Order PERU");
    }
}