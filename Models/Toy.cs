using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ToyStoreApplication.Models
{
    public class Toy
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int ToyId { get; set; }

        public int ToyPrice { get; set; }

        [ForeignKey(nameof(ToyTypeId))]
        public int ToyTypeId { get; set; }

        [ForeignKey(nameof(PlantId))]
        public int PlantId { get; set; }
    }
}
