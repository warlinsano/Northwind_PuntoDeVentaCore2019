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
    public class EmployeesAPIController : ControllerBase
    {
        private readonly NorthwindContext _context;

        public EmployeesAPIController(NorthwindContext context)
        {
            _context = context;
        }

        // GET: api/EmployeesAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employees>>> GetEmployees()
        {
            //return await _context.Employees.Select(x => x.FirstName).ToListAsync();
            return await _context.Employees.ToListAsync();
        }

        // GET: api/EmployeesAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Employees>> GetEmployees(int id)
        {
            var employees = await _context.Employees.FindAsync(id);

            if (employees == null)
            {
                return NotFound();
            }

            return employees;
        }

        // PUT: api/EmployeesAPI/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployees(int id, Employees employees)
        {
            if (id != employees.EmployeeId)
            {
                return BadRequest();
            }

            _context.Entry(employees).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeesExists(id))
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

        // POST: api/EmployeesAPI
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Employees>> PostEmployees(Employees employees)
        {
            _context.Employees.Add(employees);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployees", new { id = employees.EmployeeId }, employees);
        }

        // DELETE: api/EmployeesAPI/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Employees>> DeleteEmployees(int id)
        {
            var employees = await _context.Employees.FindAsync(id);
            if (employees == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(employees);
            await _context.SaveChangesAsync();

            return employees;
        }

        private bool EmployeesExists(int id)
        {
            return _context.Employees.Any(e => e.EmployeeId == id);
        }
    }
}
