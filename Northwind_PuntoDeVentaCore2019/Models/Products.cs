using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind_PuntoDeVentaCore2019.Models
{
    public partial class Products
    {
        public Products()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }
        [Key]
        public int ProductId { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Required]
        [Display(Name = "Supplier")]
        public int? SupplierId { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int? CategoryId { get; set; }

        [Required]
        [Display(Name = "Quantity Per Unit")]
        public string QuantityPerUnit { get; set; }

        [Display(Name = "Unit Price")]
        public decimal? UnitPrice { get; set; }

        [Display(Name = "Units In Stock")]
        public short? UnitsInStock { get; set; }

        [Display(Name = "Units On Order")]
        public short? UnitsOnOrder { get; set; }

        [Display(Name = "Reorder Level")]
        public short? ReorderLevel { get; set; }

        public bool Discontinued { get; set; }
        public byte[] Photo { get; set; }
       
        [NotMapped]
        public string PhotoBase64
        {
            get
            {
                return (Photo == null ? string.Empty : String.Format("data:image/jpg;base64,{0}", Convert.ToBase64String(Photo)));
            }
        }

        [Display(Name = "Photo Path")]
        public string PhotoPath { get; set; }

        public virtual Categories Category { get; set; }
        public virtual Suppliers Supplier { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
