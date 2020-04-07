﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Northwind_PuntoDeVentaCore2019.Data;
using Northwind_PuntoDeVentaCore2019.Models;

namespace Northwind_PuntoDeVentaCore2019.Controllers
{

    public class RegionsController : Controller
    {
        private readonly NorthwindContext _context;

        public RegionsController(NorthwindContext context)
        {
            _context = context;
        }

        // GET: Regions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Region.ToListAsync());
        }

        // GET: Regions/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var region = await _context.Region
        //        .FirstOrDefaultAsync(m => m.RegionId == id);
        //    if (region == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(region);
        //}

        // GET: Regions/Create

        // GET: Regions/Details/5
        public JsonResult Details(int? id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            var region = _context.Region.Select(r => new
            {
                Id = r.RegionId,
                Descripcion = r.RegionDescription
            }).Where(m => m.Id == id).FirstOrDefault();
            //if (region == null)
            //{
            //    return NotFound();
            //}

            return Json(region);
        }

        public IActionResult Create()
        {
            return View();
        }

        // POST: Regions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Region region)
        {
            if (ModelState.IsValid)
            {
                //_context.Region.Add(new Region { RegionDescription = region.RegionDescription });
                _context.Add(region);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(region);
        }

        // GET: Regions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var region = await _context.Region.FindAsync(id);
            if (region == null)
            {
                return NotFound();
            }
            return View(region);
        }

        // POST: Regions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RegionId,RegionDescription")] Region region)
        {
            if (id != region.RegionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(region);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegionExists(region.RegionId))
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
            return View(region);
        }

        // GET: Regions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var region = await _context.Region
                .FirstOrDefaultAsync(m => m.RegionId == id);
            if (region == null)
            {
                return NotFound();
            }

            return View(region);
        }

        // POST: Regions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var region = await _context.Region.FindAsync(id);
            _context.Region.Remove(region);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegionExists(int id)
        {
            return _context.Region.Any(e => e.RegionId == id);
        }
    }

    //public class RegionsController : Controller
    //{
    //    private readonly NorthwindContext _context;

    //    public RegionsController(NorthwindContext context)
    //    {
    //        _context = context;
    //    }

    //    // GET: Regions
    //    public async Task<IActionResult> Index()
    //    {
    //        return View(await _context.Region.ToListAsync());
    //    }

    //    // GET: Regions/Details/5
    //    public async Task<IActionResult> Details(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var region = await _context.Region
    //            .FirstOrDefaultAsync(m => m.RegionId == id);
    //        if (region == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(region);
    //    }

    //    // GET: Regions/Create
    //    public IActionResult Create()
    //    {
    //        return View();
    //    }

    //    // POST: Regions/Create
    //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    //    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Create([Bind("RegionId,RegionDescription")] Region region)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            _context.Add(region);
    //            await _context.SaveChangesAsync();
    //            return RedirectToAction(nameof(Index));
    //        }
    //        return View(region);
    //    }

    //    // GET: Regions/Edit/5
    //    public async Task<IActionResult> Edit(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var region = await _context.Region.FindAsync(id);
    //        if (region == null)
    //        {
    //            return NotFound();
    //        }
    //        return View(region);
    //    }

    //    // POST: Regions/Edit/5
    //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    //    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Edit(int id, [Bind("RegionId,RegionDescription")] Region region)
    //    {
    //        if (id != region.RegionId)
    //        {
    //            return NotFound();
    //        }

    //        if (ModelState.IsValid)
    //        {
    //            try
    //            {
    //                _context.Update(region);
    //                await _context.SaveChangesAsync();
    //            }
    //            catch (DbUpdateConcurrencyException)
    //            {
    //                if (!RegionExists(region.RegionId))
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
    //        return View(region);
    //    }

    //    // GET: Regions/Delete/5
    //    public async Task<IActionResult> Delete(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var region = await _context.Region
    //            .FirstOrDefaultAsync(m => m.RegionId == id);
    //        if (region == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(region);
    //    }

    //    // POST: Regions/Delete/5
    //    [HttpPost, ActionName("Delete")]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> DeleteConfirmed(int id)
    //    {
    //        var region = await _context.Region.FindAsync(id);
    //        _context.Region.Remove(region);
    //        await _context.SaveChangesAsync();
    //        return RedirectToAction(nameof(Index));
    //    }

    //    private bool RegionExists(int id)
    //    {
    //        return _context.Region.Any(e => e.RegionId == id);
    //    }
    //}
}
