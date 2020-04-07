using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Northwind_PuntoDeVentaCore2019.Data;
using Northwind_PuntoDeVentaCore2019.Models;

namespace Northwind_PuntoDeVentaCore2019.Controllers
{

    //[Authorize(Roles = "Administrador, Imagenes")]
    [Authorize]
    public class EmployeesController : Controller
    {
        private readonly NorthwindContext _context;

        public EmployeesController(NorthwindContext context)
        {
            _context = context;
        }

        // GET: Employees
        //public async Task<IActionResult> Index()
        //{
        //    var northwindContext = _context.Employees.Include(e => e.ReportsToNavigation);
        //    return View(await northwindContext.ToListAsync());
        //}

        public async Task<IActionResult> Index()
        {
            //var northwindContext = _context.Employees.Include(e => e.ReportsToNavigation);
            //return View(await northwindContext.ToListAsync());

            return View(await _context.Employees.ToListAsync());
        }



        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employees = await _context.Employees
                .Include(e => e.ReportsToNavigation)
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employees == null)
            {
                return NotFound();
            }

            return View(employees);
        }

        // GET: Employees/Create
        public IActionResult Create()
        {
            ViewData["ReportsTo"] = new SelectList(_context.Employees, "EmployeeId", "FirstName");
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Employees employees, IFormFile Image)
        {
            if (ModelState.IsValid)
            {
                if (Image != null)
                {
                    if (Image.Length > 0)
                    //Convert Image to byte and save to database
                    {
                        byte[] p1 = null;
                        using (var fs1 = Image.OpenReadStream())
                        using (var ms1 = new MemoryStream())
                        {
                            fs1.CopyTo(ms1);
                            p1 = ms1.ToArray();
                        }
                        employees.Photo = p1;
                    }
                }
                _context.Add(employees);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ReportsTo"] = new SelectList(_context.Employees, "EmployeeId", "FirstName", employees.ReportsTo);
            return View(employees);
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employees = await _context.Employees.FindAsync(id);
            if (employees == null)
            {
                return NotFound();
            }
            ViewData["ReportsTo"] = new SelectList(_context.Employees, "EmployeeId", "FirstName", employees.ReportsTo);
            return View(employees);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Employees employees, IFormFile Image)
        {
            if (id != employees.EmployeeId)
            {
                return NotFound();
            }

            //FormCollection
            if (ModelState.IsValid)
            {
                try
                {
                    if (Image != null)
                    {
                        if (Image.Length > 0)
                        //Convert Image to byte and save to database
                        {
                            byte[] p1 = null;
                            using (var fs1 = Image.OpenReadStream())
                            using (var ms1 = new MemoryStream())
                            {
                                fs1.CopyTo(ms1);
                                p1 = ms1.ToArray();
                            }
                            employees.Photo = p1;
                        }
                    }
                    //else
                    //{
                    //    employees.Photo = _context.Employees.Where(p => p.EmployeeId == id).Select(x => x.Photo).FirstOrDefault();
                    //}
                    _context.Update(employees);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeesExists(employees.EmployeeId))
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
            ViewData["ReportsTo"] = new SelectList(_context.Employees, "EmployeeId", "FirstName", employees.ReportsTo);
            return View(employees);
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employees = await _context.Employees
                .Include(e => e.ReportsToNavigation)
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employees == null)
            {
                return NotFound();
            }

            return View(employees);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employees = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(employees);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeesExists(int id)
        {
            return _context.Employees.Any(e => e.EmployeeId == id);
        }
    }


    //public class EmployeesController : Controller
    //{
    //    private readonly NorthwindContext _context;

    //    public EmployeesController(NorthwindContext context)
    //    {
    //        _context = context;
    //    }

    //    // GET: Employees
    //    public async Task<IActionResult> Index()
    //    {
    //        var northwindContext = _context.Employees.Include(e => e.ReportsToNavigation);
    //        return View(await northwindContext.ToListAsync());
    //    }

    //    // GET: Employees/Details/5
    //    public async Task<IActionResult> Details(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var employees = await _context.Employees
    //            .Include(e => e.ReportsToNavigation)
    //            .FirstOrDefaultAsync(m => m.EmployeeId == id);
    //        if (employees == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(employees);
    //    }

    //    // GET: Employees/Create
    //    public IActionResult Create()
    //    {
    //        ViewData["ReportsTo"] = new SelectList(_context.Employees, "EmployeeId", "FirstName");
    //        return View();
    //    }

    //    // POST: Employees/Create
    //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    //    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Create([Bind("EmployeeId,LastName,FirstName,Title,TitleOfCourtesy,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,Extension,Photo,Notes,ReportsTo,PhotoPath")] Employees employees)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            _context.Add(employees);
    //            await _context.SaveChangesAsync();
    //            return RedirectToAction(nameof(Index));
    //        }
    //        ViewData["ReportsTo"] = new SelectList(_context.Employees, "EmployeeId", "FirstName", employees.ReportsTo);
    //        return View(employees);
    //    }

    //    // GET: Employees/Edit/5
    //    public async Task<IActionResult> Edit(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var employees = await _context.Employees.FindAsync(id);
    //        if (employees == null)
    //        {
    //            return NotFound();
    //        }
    //        ViewData["ReportsTo"] = new SelectList(_context.Employees, "EmployeeId", "FirstName", employees.ReportsTo);
    //        return View(employees);
    //    }

    //    // POST: Employees/Edit/5
    //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    //    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Edit(int id, [Bind("EmployeeId,LastName,FirstName,Title,TitleOfCourtesy,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,Extension,Photo,Notes,ReportsTo,PhotoPath")] Employees employees)
    //    {
    //        if (id != employees.EmployeeId)
    //        {
    //            return NotFound();
    //        }

    //        if (ModelState.IsValid)
    //        {
    //            try
    //            {
    //                _context.Update(employees);
    //                await _context.SaveChangesAsync();
    //            }
    //            catch (DbUpdateConcurrencyException)
    //            {
    //                if (!EmployeesExists(employees.EmployeeId))
    //                {
    //                    return NotFound();
    //                }
    //                else
    //                {
    //                    throw;
    //                }
    //            }
    //            return RedirectToAction(nameof(Index));
    //        }
    //        ViewData["ReportsTo"] = new SelectList(_context.Employees, "EmployeeId", "FirstName", employees.ReportsTo);
    //        return View(employees);
    //    }

    //    // GET: Employees/Delete/5
    //    public async Task<IActionResult> Delete(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var employees = await _context.Employees
    //            .Include(e => e.ReportsToNavigation)
    //            .FirstOrDefaultAsync(m => m.EmployeeId == id);
    //        if (employees == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(employees);
    //    }

    //    // POST: Employees/Delete/5
    //    [HttpPost, ActionName("Delete")]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> DeleteConfirmed(int id)
    //    {
    //        var employees = await _context.Employees.FindAsync(id);
    //        _context.Employees.Remove(employees);
    //        await _context.SaveChangesAsync();
    //        return RedirectToAction(nameof(Index));
    //    }

    //    private bool EmployeesExists(int id)
    //    {
    //        return _context.Employees.Any(e => e.EmployeeId == id);
    //    }
    //}
}
