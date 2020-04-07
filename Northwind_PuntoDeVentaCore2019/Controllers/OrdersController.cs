using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Northwind_PuntoDeVentaCore2019.Data;
using Northwind_PuntoDeVentaCore2019.Models;
using Northwind_PuntoDeVentaCore2019.ViewModels;

namespace Northwind_PuntoDeVentaCore2019.Controllers
{
    public class OrdersController : Controller
    {
        private readonly NorthwindContext _context;

        public OrdersController(NorthwindContext context)
        {
            _context = context;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            var northwindContext = _context.Orders.Include(o => o.Customer).Include(o => o.Employee).Include(o => o.ShipViaNavigation);
            return View(await northwindContext.OrderByDescending(x => x.OrderDate).ToListAsync());
        }

        // GET: Orders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            // Esta consulta incluye el detalle del comprobante, y el producto que tiene cada comprobante. Me refiero a sus relaciones
            //_context.Comprobante.Include(x => x.ComprobanteDetalle.Select(y => y.Producto))
            //                         .Where(x => x.id == id)
            //                         .SingleOrDefault();

            var orders =  _context.Orders
                .Include(o => o.OrderDetails.Select(y => y.Product))
                .Include(o => o.Customer)
                //.Include(o => o.Employee)
                //.Include(o => o.ShipViaNavigation)
                .Where(o => o.OrderId == id)
                .SingleOrDefault();
            //.FirstOrDefaultAsync(m => m.OrderId == id);

//            (from t in db.Diseno_Certificado_Campos
//            where t.Id_Diseno_Certificado == Id_Diseno_Certificado
//            select new
//            {
//                t.Id_Diseno_Certificado_Campos,
//                t.Nombre_Campo
//            }
//                         ).ToList().Select(obj => new Diseno_Certificado_Campos
//{
//    Id_Diseno_Certificado_Campos = obj.Id_Diseno_Certificado_Campos,
//    Nombre_Campo = obj.Nombre_Campo
//}).ToList();
            
            //orders = (from o in _context.Orders
            //         where o.OrderId==id 
            //         select o).
            //         {
            //         }
            //)
                     
            if (orders == null)
            {
                return NotFound();
            }

            return View(orders);
        }

        // GET: Orders/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerId");
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "EmployeeId", "FirstName");
            ViewData["ShipVia"] = new SelectList(_context.Shippers, "ShipperId", "CompanyName");
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderId,CustomerId,EmployeeId,OrderDate,RequiredDate,ShippedDate,ShipVia,Freight,ShipName,ShipAddress,ShipCity,ShipRegion,ShipPostalCode,ShipCountry")] Orders orders)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orders);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerId", orders.CustomerId);
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "EmployeeId", "FirstName", orders.EmployeeId);
            ViewData["ShipVia"] = new SelectList(_context.Shippers, "ShipperId", "CompanyName", orders.ShipVia);
            return View(orders);
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orders = await _context.Orders.FindAsync(id);
            if (orders == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerId", orders.CustomerId);
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "EmployeeId", "FirstName", orders.EmployeeId);
            ViewData["ShipVia"] = new SelectList(_context.Shippers, "ShipperId", "CompanyName", orders.ShipVia);
            return View(orders);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderId,CustomerId,EmployeeId,OrderDate,RequiredDate,ShippedDate,ShipVia,Freight,ShipName,ShipAddress,ShipCity,ShipRegion,ShipPostalCode,ShipCountry")] Orders orders)
        {
            if (id != orders.OrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orders);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrdersExists(orders.OrderId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerId", orders.CustomerId);
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "EmployeeId", "FirstName", orders.EmployeeId);
            ViewData["ShipVia"] = new SelectList(_context.Shippers, "ShipperId", "CompanyName", orders.ShipVia);
            return View(orders);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orders = await _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.Employee)
                .Include(o => o.ShipViaNavigation)
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (orders == null)
            {
                return NotFound();
            }

            return View(orders);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orders = await _context.Orders.FindAsync(id);
            _context.Orders.Remove(orders);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrdersExists(int id)
        {
            return _context.Orders.Any(e => e.OrderId == id);
        }

        [HttpGet]
        public IActionResult Registrar()
        {
            return View(new ComprobanteViewModel());
        }

        [HttpPost]
        public IActionResult Registrar(ComprobanteViewModel model, string action)
        {
            if (action == "generar")
            {
                if (!string.IsNullOrEmpty(model.Cliente))
                {
                    //if (cl.Registrar(model.ToModel()))
                    //{
                    //    return Redirect("~/");
                    //}
                }
                else
                {
                    ModelState.AddModelError("cliente", "Debe agregar un cliente para el comprobante");
                }
            }
            else if (action == "agregar_producto")
            {
                // Si no ha pasado nuestra validación, mostramos el mensaje personalizado de error
                if (!model.SeAgregoUnProductoValido())
                {
                    ModelState.AddModelError("producto_agregar", "Solo puede agregar un producto válido al detalle");
                }
                else if (model.ExisteEnDetalle(model.CabeceraProductoId))
                {
                    ModelState.AddModelError("producto_agregar", "El producto elegido ya existe en el detalle");
                }
                else
                {
                    model.AgregarItemADetalle();
                }
            }
            else if (action == "retirar_producto")
            {
                model.RetirarItemDeDetalle();
            }
            else
            {
                throw new Exception("Acción no definida ..");
            }

            return View(model);
        }

        public JsonResult BuscarProducto(string nombre)
        {
            // List<Producto>
            //_context.Configuration.LazyLoadingEnabled = false;
            //_context.Configuration.ProxyCreationEnabled = false;
            var data = _context.Products.OrderBy(x => x.ProductName)
                                        .Select(x=> new
                                        {
                                            id =  x.ProductId,
                                            value = x.ProductName,
                                            precio = x.UnitPrice
                                        })
                                        .Where(x => x.value.Contains(nombre))
                                        .Take(10)
                                        .ToList();

            return Json( data);
        }

        public JsonResult BuscarCliente(string nombre)
        {
            // List<Producto>
            //_context.Configuration.LazyLoadingEnabled = false;
            //_context.Configuration.ProxyCreationEnabled = false;
            var data = _context.Employees.OrderBy(x => x.FirstName)
                                        .Select(x => new
                                        {
                                            id = x.EmployeeId,
                                            value = x.FirstName+" "+x.LastName,
                                        })
                                        .Where(x => x.value.Contains(nombre))
                                        .Take(10)
                                        .ToList();

            return Json(data);
        }

    }
}
