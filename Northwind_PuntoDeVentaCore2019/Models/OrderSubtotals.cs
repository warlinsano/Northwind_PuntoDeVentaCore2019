using System;
using System.Collections.Generic;

namespace Northwind_PuntoDeVentaCore2019.Models
{
    public partial class OrderSubtotals
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
