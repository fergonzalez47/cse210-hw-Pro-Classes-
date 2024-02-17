using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Clear();
        //ADDRESS
        Address usAddress = new Address("123 Main St", "Anytown", "CA", "USA");
        Address otherAddress = new Address("456 El alto", "Guayana", "Bolivar", "venezuela");

        //Customer
        Customer customer1 = new Customer("Fernando Gonzalez", usAddress);
        Customer customer2 = new Customer("Pierina Valdez", otherAddress);

        //PRODUCTS

        Product food1 = new Product("Apples", "1", 2.5, 5);
        Product food2 = new Product("Rice", "2", 1.8, 3);
        Product food3 = new Product("Milk", "3", 3.0, 2);
        Product food4 = new Product("Chicken", "4", 7.5, 4);
        Product food5 = new Product("Bread", "5", 2.0, 1);
        Product food6 = new Product("Carrots", "6", 1.2, 6);



        //ORDER 1

        Console.WriteLine("********* ORDER 1 *********");
        Order order1 = new Order();
        order1.SetCustomer(customer1);
        order1.AddProduct(food1);
        order1.AddProduct(food2);
        order1.AddProduct(food3);
        order1.ShippingLabel();
        order1.PackingLabel();



        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("********* ORDER 2 *********");
        //ORDER 2

        Order order2 = new Order();
        order2.SetCustomer(customer2);
        order2.AddProduct(food4);
        order2.AddProduct(food5);
        order2.AddProduct(food6);
        order2.ShippingLabel();
        order2.PackingLabel();
    }
}