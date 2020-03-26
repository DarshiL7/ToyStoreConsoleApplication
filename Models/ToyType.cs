using System;
using System.Collections.Generic;
using System.Text;

namespace ToyStoreApplication.Models
{
    public class ToyType
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int ToyTypeId { get; set; }

        public string ToyTypeName { get; set; }


    }
}
