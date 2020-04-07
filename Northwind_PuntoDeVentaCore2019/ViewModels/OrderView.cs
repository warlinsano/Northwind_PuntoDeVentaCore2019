using Northwind_PuntoDeVentaCore2019.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind_PuntoDeVentaCore2019.ViewModels
{
    public class OrderView
    {

        public Customers Customers { get; set; }

        public List<ProductOrderView> products { get; set; }


    }
}


