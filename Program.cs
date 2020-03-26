using System;
using ToyStoreApplication.Domains;
using ToyStoreApplication.Models;

namespace ToyStoreApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer20 = new Customer();
            Plant plant10 = new Plant();
            ToyDomain toyDomain = new ToyDomain();
            PlantDomain plantDomain = new PlantDomain();
            ToyType toyType10 = new ToyType();
            Customer customer = new Customer();
            ToyTypeDomain toyTypeDomain = new ToyTypeDomain();
            CustomerDomain customerDomain = new CustomerDomain();
            OrderDomain orderDomain = new OrderDomain();

            repeate:
            Console.WriteLine("--->>Welcome to Toy Store application<<---");

            Console.WriteLine("-->>Choose form the below given options<<--");

            Console.WriteLine("=1.1:->Enter ToyType..{this option adds which type of toy you Manufacturing}");
            Console.WriteLine("=1.2:->Show list of ToyTypes..{this option shows whole list of entered ToyTypes}");
            Console.WriteLine("=1.3:->Delete ToyType..{this option deletes selected field}");
            Console.WriteLine("=2.1:->Enter Plant..{this option adds the information regarding to the Manufacturing Plants}");
            Console.WriteLine("=2.2:->Show  list of Plants..{this option shows list of Manufacturing Plants}");
            Console.WriteLine("=2.3:->Delete Plant..{this option deletes Manufacturing plants}");
            Console.WriteLine("=3.1:->Enter Customer..{this option adds the information regarding to Customer}");
            Console.WriteLine("=3.2:->Show list of Customers..{this option shows list of Customers}");
            Console.WriteLine("=3.3:->Delete Customer..{this option deletes Customers}");
            Console.WriteLine("=4.1:->Enter Toys..{this option adds information regarding to the Toys}");
            Console.WriteLine("=4.2:->Show list of Toys..{this option shows the list of enterd Toys}");
            Console.WriteLine("=5.1:->Enter Order..{this option adds order details}");
            Console.WriteLine("=5.2:->Show list of Orders..{this option shows the list of enterd Orders}");
            Console.WriteLine("Enter any other numeric key to Exit the program");
            double c = double.Parse(Console.ReadLine());

            switch (c)
            {
                case 1.1:
                    toyTypeDomain.AddToyType();
                    Console.WriteLine("");
                    goto repeate;
                
                case 1.2:
                    Console.WriteLine("Id\t ToyType");
                    foreach (ToyType toyType in toyTypeDomain.GetToyType())
                    {
                        Console.WriteLine($"{toyType.ToyTypeId}\t  {toyType.ToyTypeName}");
                    }
                    Console.WriteLine("");
                    goto repeate;

                case 1.3:
                    Console.WriteLine("--->>Delete ToyType<<---");
                    Console.WriteLine("Enter typeId");
                    toyType10.ToyTypeId = Int32.Parse(Console.ReadLine());
                    toyTypeDomain.DeleteToyType(toyType10);
                    Console.WriteLine("");
                    goto repeate;

                case 2.1:
                    plantDomain.AddPlant();
                    Console.WriteLine("");
                    goto repeate;

                case 2.2:
                    Console.WriteLine("Id\tPlantName PlantAddress");
                    foreach (Plant plant in plantDomain.GetAllPlant())
                    {
                        Console.WriteLine($"{plant.PlantId}\t{plant.PlantName}\t\t{plant.PlantAddress}");
                    }
                    Console.WriteLine("");
                    goto repeate;

                case 2.3:
                    Console.WriteLine("--->> Delete Plant <<---");
                    Console.WriteLine("Enter Id To delete Plant: ");
                    plant10.PlantId = Int32.Parse(Console.ReadLine());
                    plantDomain.DeletePlant(plant10);
                    Console.WriteLine("");
                    goto repeate;

                case 3.1:
                    customerDomain.AddCustomer();
                    Console.WriteLine("");
                    goto repeate;

                case 3.2:
                    Console.WriteLine("\n--->> View All Customers <<---");

                    Console.WriteLine("Id \t CustomerName \t CustomerAddress");
                    foreach (Customer customer1 in customerDomain.GetAllCustomers())
                    {

                        Console.WriteLine($"{customer1.CustomerId}\t  {customer1.CustomerName}\t\t{customer1.CustomerPermanentAddress} ");
                    }
                    Console.WriteLine("");
                    goto repeate;

                case 3.3:
                    Console.WriteLine("--->> Delete Plant <<---");
                    Console.WriteLine("Enter Id To delete Plant: ");
                    customer20.CustomerId = Int32.Parse(Console.ReadLine());
                    customerDomain.DeleteCustomer(customer20);
                    Console.WriteLine("");
                    goto repeate;

                case 4.1:
                    toyDomain.AddToy();
                    Console.WriteLine("");
                    goto repeate;

                case 4.2:
                    Console.WriteLine("\n--->> View All Toys <<---");

                    Console.WriteLine("Id \t ToyPrice\tToyTypeId\tPlantId");
                    foreach (Toy toy in toyDomain.GetAllToy())
                    {
                        Console.WriteLine($"{toy.ToyId}\t  {toy.ToyPrice}\t\t{toy.ToyTypeId}\t\t{toy.PlantId} ");
                    }
                    Console.WriteLine("");
                    goto repeate;

                case 5.1:
                    orderDomain.AddOrder();
                    Console.WriteLine("");
                    goto repeate;

                case 5.2:
                    Console.WriteLine("\n--->> View All Orders <<---");

                    Console.WriteLine("Id \tQuantity\tAddress\tDiscount\tToyId\tCustomerId");
                    foreach (Order order in orderDomain.GetAllOrders())
                    {
                        Console.WriteLine($"{order.OrderId}\t{order.OrderQuantity}\t\t{order.OrderAddress}\t{order.OrderDiscount}\t\t{order.ToyId}\t\t{order.CustomerId} ");
                    }
                    Console.WriteLine("");
                    goto repeate;

                default:
                    break;




            }

            /* customerDomain.AddCustomer();*/

            /*Console.WriteLine("\n--->> View All Customers <<---");

            Console.WriteLine("Id \t CustomerName \t CustomerAddress");
            foreach (Customer customer1 in customerDomain.GetAllCustomers())
            {

                Console.WriteLine($"{customer1.CustomerId}\t  {customer1.CustomerName}\t\t{customer1.CustomerPermanentAddress} ");
            }

            
            Console.WriteLine("--->> Delete Customer <<---");
            Console.WriteLine("Enter Id To delete Customer: ");
            customer.CustomerId = Int32.Parse(Console.ReadLine());
            
           
            Console.WriteLine("Hello World!");
            Console.ReadLine();*/

            /*toyTypeDomain.AddToyType();*/

            /*Console.Writeline("Delete ToyType");
             Console.WriteLine("Enter typeId");
            toyType.ToyTypeId = Int32.Parse(Console.ReadLine());
            toyTypeDomain.DeleteToyType(toyType);*/

            /*toyDomain.AddToy();*/

            /*Console.WriteLine("\n--->> View All Toys <<---");

            Console.WriteLine("Id \t ToyPrice\tToyTypeId\tPlantId" );
            foreach (Toy toy in toyDomain.GetAllToy())
            {
                Console.WriteLine($"{toy.ToyId}\t  {toy.ToyPrice}\t\t{toy.ToyTypeId}\t\t{toy.PlantId} ");
            }*/


            //orderDomain.AddOrder();

            /*Console.WriteLine("\n--->> View All Orders <<---");

            Console.WriteLine("Id \tQuantity\tAddress\tDiscount\tToyId\tCustomerId");
            foreach (Order order in orderDomain.GetAllOrders())
            {
                Console.WriteLine($"{order.OrderId}\t{order.OrderQuantity}\t\t{order.OrderAddress}\t{order.OrderDiscount}\t\t{order.ToyId}\t\t{order.CustomerId} ");
            }*/

        }
    }
}
