using OnlineOrdering;

class Program
{
    static void Main(string[] args)
    {
        Address adress1 = new Address("Entre Rios", "San Rafael", "Mendoza", "Argentina");
        Customer customer1 = new Customer("Santiago Bergerat", adress1);
        Order order = new Order(customer1);


        Address address2 = new Address("123 Elm St", "Dallas", "TX", "USA");
        Customer customer2 = new Customer("Emily Smith", address2);
        Order order2 = new Order(customer2);




        Product product1 = new Product("Yerba Mate", "Y001", 3.50, 2);
        Product product2 = new Product("Dulce de Leche", "D002", 5.00, 1);
        Product product3 = new Product("Keyboard", "K001", 20.00, 1);
        Product product4 = new Product("Mouse", "M002", 10.00, 2);


        order.AddProduct(product1);
        order.AddProduct(product2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);




        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalPrice()}");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");



    }
}