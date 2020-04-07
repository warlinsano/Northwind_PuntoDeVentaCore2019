using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind_PuntoDeVentaCore2019.Models
{
    public partial class OrderDetails
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }

        [NotMapped]
        public decimal Monto
        {
            get
            {
                return Quantity * UnitPrice;
            }
        }

        //
        [NotMapped]
        public decimal MontoConDescuento
        {
            get
            {
                return Monto - Convert.ToDecimal(Discount);
            }
        }

        public virtual Orders Order { get; set; }
        public virtual Products Product { get; set; }
    }
}
