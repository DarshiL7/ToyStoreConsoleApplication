using System;
using System.Collections.Generic;
using System.Text;

namespace ToyStoreApplication.Models
{
    public class Plant
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int PlantId { get; set; }

        public string PlantName { get; set; }
        
        public string PlantAddress { get; set; }


    }
}
