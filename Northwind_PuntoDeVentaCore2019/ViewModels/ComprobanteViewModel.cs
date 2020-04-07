using Northwind_PuntoDeVentaCore2019.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind_PuntoDeVentaCore2019.ViewModels
{
    public class ComprobanteViewModel
    {
        #region Cabecera
            public string ClienteId { get; set; }
            public string Cliente { get; set; }
            public int CabeceraProductoId { get; set; }
            public string CabeceraProductoNombre { get; set; }
            public int CabeceraProductoCantidad { get; set; }
            public decimal CabeceraProductoPrecio { get; set; }
            #endregion

            #region Contenido
            public List<ComprobanteDetalleViewModel> ComprobanteDetalle { get; set; }
            #endregion

            #region Pie
            public decimal Total()
            {
                return ComprobanteDetalle.Sum(x => x.Monto());
            }
            public DateTime Creado { get; set; }
            #endregion

            public ComprobanteViewModel()
            {
                ComprobanteDetalle = new List<ComprobanteDetalleViewModel>();
                Refrescar();
            }

            public void Refrescar()
            {
                CabeceraProductoId = 0;
                CabeceraProductoNombre = null;
                CabeceraProductoCantidad = 1;
                CabeceraProductoPrecio = 0;
            }

            public bool SeAgregoUnProductoValido()
            {
                return !(CabeceraProductoId == 0 || string.IsNullOrEmpty(CabeceraProductoNombre) || CabeceraProductoCantidad == 0 || CabeceraProductoPrecio == 0);
            }

            public bool ExisteEnDetalle(int ProductoId)
            {
                return ComprobanteDetalle.Any(x => x.ProductoId == ProductoId);
            }

            public void RetirarItemDeDetalle()
            {
                if (ComprobanteDetalle.Count > 0)
                {
                    var detalleARetirar = ComprobanteDetalle.Where(x => x.Retirar)
                                                            .SingleOrDefault();

                    ComprobanteDetalle.Remove(detalleARetirar);
                }
            }

            public void AgregarItemADetalle()
            {
                ComprobanteDetalle.Add(new ComprobanteDetalleViewModel
                {
                    ProductoId = CabeceraProductoId,
                    ProductoNombre = CabeceraProductoNombre,
                    PrecioUnitario = CabeceraProductoPrecio,
                    Cantidad = CabeceraProductoCantidad,
                });

                Refrescar();
            }

            public Orders ToModel()
            {
                var orders = new Orders();
                 orders.CustomerId = "ANATR";
                 orders.EmployeeId = 1;
                 orders.OrderDate = DateTime.Now;
                //comprobante.Total = this.Total();

                foreach (var d in ComprobanteDetalle)
                {
                    orders.OrderDetails.Add(new OrderDetails
                    {
                        OrderId = orders.OrderId,
                        ProductId= d.ProductoId
                        //,
                        //UnitPrice= d.,
                        //PrecioUnitario = d.PrecioUnitario,
                        //Cantidad = d.Cantidad
                    });
                }

                return orders;
            }
        
    }
}
