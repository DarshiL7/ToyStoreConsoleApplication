using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToyStoreApplication.Context;
using ToyStoreApplication.Models;

namespace ToyStoreApplication.Domains
{
    public class ToyTypeDomain:BaseContext
    {
        ToyType toyType = new ToyType();

        public void AddToyType()
        {
            repeate:
            Console.WriteLine("--->>Enter ToyType Details<<--");

            Console.WriteLine("Enter ToyType Name: ");
            toyType.ToyTypeName = Console.ReadLine();

            if (toyType.ToyTypeName!=null)
            {
                ToyTypes.Add(toyType);
                SaveChanges();
            }
            else
            {
                Console.WriteLine("Enter all requierd data");
                goto repeate;
            }
        }

        public void DeleteToyType(ToyType toyType10)
        {
            ToyTypes.Remove(toyType10);
            SaveChanges();
            Console.WriteLine("ToyTypeId " + toyType10.ToyTypeId + " Deleted");
        }

        public List<ToyType> GetToyType()
        {
            return ToyTypes.ToList();
        }
    }
}
