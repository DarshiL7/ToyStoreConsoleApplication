using System;
using System.Collections.Generic;
using System.Text;

namespace ToyStoreApplication.Models
{
    public class Customer
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string CustomerPermanentAddress { get; set; }
    }
}
