using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToyStoreApplication.Context;
using ToyStoreApplication.Models;

namespace ToyStoreApplication.Domains
{
    public class OrderDomain : BaseContext
    {
        CustomerDomain customerDomain = new CustomerDomain();
        ToyDomain toyDomain = new ToyDomain();
        Order order = new Order();
        public void AddOrder()
        {
            repeate:
            Console.WriteLine("--->>Add Order details<<---");
            Console.WriteLine("Order Quantity:");
            order.OrderQuantity = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Order Address: ");
            order.OrderAddress = Console.ReadLine();

            if (order.OrderQuantity<=50)
            {
                order.OrderDiscount = 5;
            }
            else if (order.OrderQuantity > 50 && order.OrderQuantity <= 100)
            {
                order.OrderDiscount = 10;
            }
            else if (order.OrderQuantity > 100 && order.OrderQuantity <= 200)
            {
                order.OrderDiscount = 15;
            }
            else if (order.OrderQuantity > 200 && order.OrderQuantity <= 400)
            {
                order.OrderDiscount = 20;
            }
            else
            {
                order.OrderDiscount = 30;
            }
            Console.WriteLine("Select ToyId From bellow options");
            Console.WriteLine("Id \t ToyPrice\tToyTypeId\tPlantId");
            foreach (Toy toy in toyDomain.GetAllToy())
            {
                Console.WriteLine($"{toy.ToyId}\t  {toy.ToyPrice}\t\t{toy.ToyTypeId}\t\t{toy.PlantId} ");
            }
            Console.WriteLine("Enter ToyId");
            order.ToyId = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Select CustomerId From bellow options");
            Console.WriteLine("Id \t CustomerName \t CustomerAddress");
            foreach (Customer customer1 in customerDomain.GetAllCustomers())
            {
                Console.WriteLine($"{customer1.CustomerId}\t  {customer1.CustomerName}\t\t{customer1.CustomerPermanentAddress} ");
            }
            Console.WriteLine("Enter CustomerId");
            order.CustomerId = Int32.Parse(Console.ReadLine());

            if (order.OrderQuantity!=0&&order.ToyId!=0&&order.OrderDiscount!=0&&order.OrderAddress!=null&&order.CustomerId!=0)
            {
                try
                {
                    Console.WriteLine("You get Discount of "+order.OrderDiscount+"%");
                    Orders.Add(order);
                    SaveChanges();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
                
                
            }
            else
            {
                Console.WriteLine(" !!Enter all required fields!! ");
                goto repeate;
            }


        }

        public List<Order> GetAllOrders()
        {
            return Orders.ToList();
        }
    }
}
