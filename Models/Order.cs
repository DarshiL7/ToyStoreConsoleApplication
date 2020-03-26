using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ToyStoreApplication.Models
{
    public class Order
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int OrderId { get; set; }

        public int OrderQuantity { get; set; }

        public string OrderAddress { get; set; }

        public int OrderDiscount { get; set; }

        [ForeignKey(nameof(ToyId))]
        public int ToyId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public int CustomerId { get; set; }
    }
}
