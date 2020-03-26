using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToyStoreApplication.Context;
using ToyStoreApplication.Models;

namespace ToyStoreApplication.Domains
{
    
    public class ToyDomain : BaseContext
    {
        Plant plant = new Plant();
        PlantDomain plantDomain = new PlantDomain();
        Toy toy = new Toy();
        ToyType toyType = new ToyType();
        ToyTypeDomain toyTypeDomain = new ToyTypeDomain();
        
        
        

        public void AddToy()
        {
            repeate:
            Console.WriteLine("--->> ADD Toys <<---");
            Console.WriteLine("-->Select id from given ToyTypes<--");
            Console.WriteLine("Id\t ToyType");
            foreach (ToyType toyType in toyTypeDomain.GetToyType())
            {

                Console.WriteLine($"{toyType.ToyTypeId}\t  {toyType.ToyTypeName}");
                 
               
            }
            Console.WriteLine("-->Select id from given Plant List<--");
            Console.WriteLine("Id\tPlantName\tPlantAddress");
            foreach (Plant plant in plantDomain.GetAllPlant())
            {

                Console.WriteLine($"{plant.PlantId}\t  {plant.PlantName}\t\t{plant.PlantAddress} ");
            }


            Console.WriteLine("Enter Toy Price: ");
            toy.ToyPrice = Int32.Parse( Console.ReadLine());
            Console.WriteLine("Enter ToyTypeId:");
            toy.ToyTypeId = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter PlantId:");
            toy.PlantId = Int32.Parse(Console.ReadLine());
            
            if (toy.PlantId!=0&&toy.ToyPrice!=0&&toy.ToyTypeId!=0)
            {
                try
                {
                    
                    Toys.Add(toy);
                    SaveChanges();
                }
                catch (Exception e)
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

        public List<Toy> GetAllToy()
        {

            return Toys.ToList();

            
        }
    }
}

