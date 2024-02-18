using System;
namespace Foundation2
{
class Program
{
    static void Main(string[] args)
    {Product prod1 = new Product("T-Shirt", "1234", 19.99, 4);
        Product prod2 = new Product("Shorts", "5678", 59.95, 2);
        Product prod3 = new Product("Tennis Shoes", "9637", 139.99, 1);

        Order order1 = new Order();
        Address address1 = new Address("1953 S Peach Ln", "Spokane Valley", "WA", "USA");
        Customer cust1 = new Customer("Martha Livingston", address1);
        order1.AddItem(prod1);
        order1.AddItem(prod3);
        
        order1.PrintTotalCost(address1);
        order1.PrintPackingLabel();
        order1.PrintShippingLabel(address1, cust1);
        Console.WriteLine();

        Order order2 = new Order();
        Address address2 = new Address("19 Old Hope Rd", "Kingston 10", "Kingston", "Jamaica");
        Customer cust2 = new Customer("David Campbell", address2);
        order2.AddItem(prod1);
        order2.AddItem(prod2);
        order2.AddItem(prod3);
        
        order2.PrintTotalCost(address2);
        order2.PrintPackingLabel();
        order2.PrintShippingLabel(address2, cust2);

    }
}
}