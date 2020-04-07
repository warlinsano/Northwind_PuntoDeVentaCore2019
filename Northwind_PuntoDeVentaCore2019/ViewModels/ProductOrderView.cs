using Northwind_PuntoDeVentaCore2019.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind_PuntoDeVentaCore2019.ViewModels
{
    public class ProductOrderView : Products
    {
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString ="{0:N2}", ApplyFormatInEditMode =false)]
        [Required]
        public float Quantity { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal value { get { return (decimal)UnitPrice * (decimal)Quantity; } }
    }
}
