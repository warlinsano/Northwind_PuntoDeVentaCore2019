using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Northwind_PuntoDeVentaCore2019.Data;
using Northwind_PuntoDeVentaCore2019.Models;

namespace Northwind_PuntoDeVentaCore2019.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersAPIController : ControllerBase
    {
        private readonly NorthwindContext _context;

        public SuppliersAPIController(NorthwindContext context)
        {
            _context = context;
        }

        // GET: api/SuppliersAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Suppliers>>> GetSuppliers()
        {
            return await _context.Suppliers.ToListAsync();
        }

        // GET: api/SuppliersAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Suppliers>> GetSuppliers(int id)
        {
            var suppliers = await _context.Suppliers.FindAsync(id);

            if (suppliers == null)
            {
                return NotFound();
            }

            return suppliers;
        }

        // PUT: api/SuppliersAPI/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSuppliers(int id, Suppliers suppliers)
        {
            if (id != suppliers.SupplierId)
            {
                return BadRequest();
            }

            _context.Entry(suppliers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SuppliersExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/SuppliersAPI
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Suppliers>> PostSuppliers(Suppliers suppliers)
        {
            _context.Suppliers.Add(suppliers);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSuppliers", new { id = suppliers.SupplierId }, suppliers);
        }

        // DELETE: api/SuppliersAPI/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Suppliers>> DeleteSuppliers(int id)
        {
            var suppliers = await _context.Suppliers.FindAsync(id);
            if (suppliers == null)
            {
                return NotFound();
            }

            _context.Suppliers.Remove(suppliers);
            await _context.SaveChangesAsync();

            return suppliers;
        }

        private bool SuppliersExists(int id)
        {
            return _context.Suppliers.Any(e => e.SupplierId == id);
        }
    }
}
