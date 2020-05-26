using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Drawing;

namespace Online_shoping.Models
{
    public class CategoryDetail
    {
        public int CategoryId { get; set; }
        [Required (ErrorMessage = "Required Category Name")]
        [StringLength(100, ErrorMessage = "Required min 3 max 100 char", MinimumLength =3)]
        public string CategoryName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }
    }

    public class ProductDetail
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Required product Name")]
        [StringLength(100, ErrorMessage = "Required min 3 max 100 char", MinimumLength = 3)]
        public string ProductName { get; set; }
        [Required]
        [Range(1, 50)]
        public Nullable<int> CategoryId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        [Required(ErrorMessage = "Discription required")]
        public Nullable<System.DateTime> Description { get; set; }
        public string ProductImage { get; set; }
        public bool? IsFeatured { get; set; }
        [Required]
        [Range(typeof(int),"1","50",ErrorMessage ="invaild quantity")]
        public Nullable<int> Quantity { get; set; }
        [Required]
        [Range(typeof(decimal), "1", "200000", ErrorMessage = "invaild price")]
        public Nullable<decimal> Price { get; set; }
        public SelectList Category { get; set; }

    }
}