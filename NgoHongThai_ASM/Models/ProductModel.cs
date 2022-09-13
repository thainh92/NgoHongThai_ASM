using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace NgoHongThai_ASM.Models
{
    public class ProductModel
    {
        [Key]
        public long ProductId { get; set; }

        [Required]
        [StringLength(32, MinimumLength = 3, ErrorMessage = "Product name must be between 3 to 32 characters")]
        public string Name { get; set; }

        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "Price must be a positive number and greater than 0")]
        public double Price { get; set; }

        [Required]
        [Range(1, 100, ErrorMessage = "Please enter quantity from 1 to 100")]
        public long Quantity { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        [DataType(DataType.DateTime, ErrorMessage = "Date format must be dd/mm/yyyy")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Category Id")]
        public long CategoryId { get; set; }
        public virtual CategoryModel Category { get; set; }
    }
}