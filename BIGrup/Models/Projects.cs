using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BIGrup.Models
{
    public class Projects
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        [DisplayName("Product Name")]
        public string Name { get; set; }
        public string Type { get; set; }
        public string Region { get; set; }
        public string Organization { get; set; }

        [DataType(DataType.Date)]
        public DateTime Since { get; set; }
        [DataType(DataType.Date)]
        public DateTime End { get; set; }
        public string Status { get; set; }
        public decimal Price { get; set; }
    }
}
}
