using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToyStoreApplication.Context;
using ToyStoreApplication.Models;

namespace ToyStoreApplication.Domains
{
    class PlantDomain : BaseContext
    {
        Plant plant = new Plant();
        public void AddPlant()
        {
            repeate:
            Console.WriteLine("--->> ADD PLANTS <<---");
            Console.WriteLine("Enter Plant Name: ");
            plant.PlantName = Console.ReadLine();
            Console.WriteLine("Enter Plant Address: ");
            plant.PlantAddress = Console.ReadLine();
            if (plant.PlantName!=null&&plant.PlantAddress!=null)
            {
                try
                {
                    Plants.Add(plant);
                    SaveChanges();
                    Console.WriteLine("Manufecturing plants are added");
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

        public List<Plant> GetAllPlant()
        {
            return Plants.ToList();
        }

        public void DeletePlant(Plant plant10)
        {

            
            Plants.Remove(plant10);
            SaveChanges();
            Console.WriteLine("Plant "+plant10.PlantId+" Deleted");
            
           
        }

        
    }
}
