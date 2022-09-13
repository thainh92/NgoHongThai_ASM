using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NgoHongThai_ASM.Models
{
    public class CategoryModel
    {
        [Key]
        public long CategoryId { get; set; }

        [Required]
        [StringLength(32, MinimumLength = 3, ErrorMessage = "Product name must be between 3 to 32 characters")]
        public string CategoryName { get; set; }
        public virtual ICollection<ProductModel> Products { get; set; }
    }
}