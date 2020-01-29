using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPages.Models
{
    public class Flats
    {
        [Key]
        public int ProductID { get; set; }

        [DisplayName("Naming Сonstruction ")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string Type { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string Region { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string Organization { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime Since { get; set; }

        [Display(Name = " Expiry  Date")]
        [DataType(DataType.Date)]
        public DateTime End { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string Status { get; set; }

        [Column(TypeName = "decimal(18, 0)")]
        public decimal Price { get; set; }

        //public class FlatsDBContext : DbContext
        //{
        //    public DbSet<Flats> FlatsModels { get; set; }
        //}
    }
}
