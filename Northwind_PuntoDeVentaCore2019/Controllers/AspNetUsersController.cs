using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Northwind_PuntoDeVentaCore2019.Data;
using Northwind_PuntoDeVentaCore2019.Helpers;
using Northwind_PuntoDeVentaCore2019.Models;

namespace Northwind_PuntoDeVentaCore2019.Controllers
{

    public class AspNetUsersController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        //private readonly IUserHelper _userHelper;
        private readonly NorthwindContext _context;
        public AspNetUsersController(
            NorthwindContext context,
             UserManager<IdentityUser> userManager
          )
        {
            _userManager = userManager;
            _context = context;
        }

        //private readonly ApplicationDbContext _context1;
        //public AspNetUsersController(ApplicationDbContext context)
        //{
        //    _context1 = context;
        //}


        // GET: AspNetUsers
        public async Task<IActionResult> Index()
        {
            return View(await _context.AspNetUsers.ToListAsync());
        }

        // GET: AspNetUsers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }


            //var aspNetUsers = await _userHelper.GetUsersByIdAsync(id);
            //var aspNetUsers = await _userManager.FindByIdAsync(id);

            var aspNetUsers = await _context.AspNetUsers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aspNetUsers == null)
            {
                return NotFound();
            }

            return View(aspNetUsers);
        }

        // GET: AspNetUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AspNetUsers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] AspNetUsers aspNetUsers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aspNetUsers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aspNetUsers);
        }

        // GET: AspNetUsers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aspNetUsers = await _context.AspNetUsers.FindAsync(id);
            if (aspNetUsers == null)
            {
                return NotFound();
            }

            //_context1.Users.Select(x=>x.UserName).ToList();

            //        SELECT R.[Name]
            //        FROM[Northwind].[dbo].[AspNetRoles] R,  [Northwind].[dbo].AspNetUserRoles UR,  [Northwind].[dbo].AspNetUsers U
            //        WHERE r.ID= UR.RoleId AND U.Id= UR.UserId AND UR.UserId= '3cbd5dc2-510f-4598-a067-6bbc245a969c'

            //obtengo los roles que tiene este  usuario
            //var iduser = "3cbd5dc2-510f-4598-a067-6bbc245a969c";
            var MisRoles = _context.AspNetUserRoles
              .Where(
                 y => y.UserId == y.User.Id
                 && y.RoleId == y.Role.Id
                 && y.User.Id == id).Select(x => x.Role.Name).ToArray();

            //obtengo todos los roles de la tabla  roles
            var AllRole = _context.AspNetRoles.ToArray();

            string[,] todosRoles;
            todosRoles = new string[AllRole.Count(), 2];
            for (int i = 0; i < AllRole.Count(); i++)
            {
                if (MisRoles.Contains(AllRole[i].Name.ToString()))
                {
                    todosRoles[i, 0] = AllRole[i].Name;
                    todosRoles[i, 1] = "true";
                }
                else
                {
                    todosRoles[i, 0] = AllRole[i].Name;
                    todosRoles[i, 1] = "false";
                }
            }
            //todosRoles;

            AspNetUsers usuario = new AspNetUsers
            {
                Id = aspNetUsers.Id,
                UserName = aspNetUsers.UserName,
                NormalizedUserName = aspNetUsers.NormalizedUserName,
                Email = aspNetUsers.Email,
                todosRoles = todosRoles
            };

            //var mir = _context.AspNetRoles(x=>x.)
            //return View(aspNetUsers);
            //ViewBag.Estado = new SelectList(lst, "Value", "Text", usuario.Estado);
            LlenarDdlEstado(usuario.Estado);
            return View(usuario);
        }

        // POST: AspNetUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] AspNetUsers aspNetUsers)
        {
            if (id != aspNetUsers.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aspNetUsers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AspNetUsersExists(aspNetUsers.Id))
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
            return View(aspNetUsers);
        }

        // GET: AspNetUsers/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aspNetUsers = await _context.AspNetUsers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aspNetUsers == null)
            {
                return NotFound();
            }

            return View(aspNetUsers);
        }

        // POST: AspNetUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var aspNetUsers = await _context.AspNetUsers.FindAsync(id);
            _context.AspNetUsers.Remove(aspNetUsers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        //llena el DDL de Estado  en Editar
        private void LlenarDdlEstado(bool Estado)
        {
            List<SelectListItem> lst = new List<SelectListItem>();
            lst.Add(new SelectListItem() { Text = "Habilitado", Value = "true" });
            lst.Add(new SelectListItem() { Text = "Desabilitado", Value = "false" });
            ViewBag.Estado = new SelectList(lst, "Value", "Text", Estado);
        }

        private bool AspNetUsersExists(string id)
        {
            return _context.AspNetUsers.Any(e => e.Id == id);
        }

        public async Task<IActionResult> UserActivityLog()
        {
            return View(await _context.AspNetUsers.ToListAsync());
        }


    }











    //public class AspNetUsersController : Controller
    //{
    //    private readonly NorthwindContext _context;

    //    public AspNetUsersController(NorthwindContext context)
    //    {
    //        _context = context;
    //    }

    //    // GET: AspNetUsers
    //    public async Task<IActionResult> Index()
    //    {
    //        return View(await _context.AspNetUsers.ToListAsync());
    //    }

    //    // GET: AspNetUsers/Details/5
    //    public async Task<IActionResult> Details(string id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var aspNetUsers = await _context.AspNetUsers
    //            .FirstOrDefaultAsync(m => m.Id == id);
    //        if (aspNetUsers == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(aspNetUsers);
    //    }

    //    // GET: AspNetUsers/Create
    //    public IActionResult Create()
    //    {
    //        return View();
    //    }

    //    // POST: AspNetUsers/Create
    //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    //    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Create([Bind("Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] AspNetUsers aspNetUsers)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            _context.Add(aspNetUsers);
    //            await _context.SaveChangesAsync();
    //            return RedirectToAction(nameof(Index));
    //        }
    //        return View(aspNetUsers);
    //    }

    //    // GET: AspNetUsers/Edit/5
    //    public async Task<IActionResult> Edit(string id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var aspNetUsers = await _context.AspNetUsers.FindAsync(id);
    //        if (aspNetUsers == null)
    //        {
    //            return NotFound();
    //        }
    //        return View(aspNetUsers);
    //    }

    //    // POST: AspNetUsers/Edit/5
    //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    //    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Edit(string id, [Bind("Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] AspNetUsers aspNetUsers)
    //    {
    //        if (id != aspNetUsers.Id)
    //        {
    //            return NotFound();
    //        }

    //        if (ModelState.IsValid)
    //        {
    //            try
    //            {
    //                _context.Update(aspNetUsers);
    //                await _context.SaveChangesAsync();
    //            }
    //            catch (DbUpdateConcurrencyException)
    //            {
    //                if (!AspNetUsersExists(aspNetUsers.Id))
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
    //        return View(aspNetUsers);
    //    }

    //    // GET: AspNetUsers/Delete/5
    //    public async Task<IActionResult> Delete(string id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var aspNetUsers = await _context.AspNetUsers
    //            .FirstOrDefaultAsync(m => m.Id == id);
    //        if (aspNetUsers == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(aspNetUsers);
    //    }

    //    // POST: AspNetUsers/Delete/5
    //    [HttpPost, ActionName("Delete")]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> DeleteConfirmed(string id)
    //    {
    //        var aspNetUsers = await _context.AspNetUsers.FindAsync(id);
    //        _context.AspNetUsers.Remove(aspNetUsers);
    //        await _context.SaveChangesAsync();
    //        return RedirectToAction(nameof(Index));
    //    }

    //    private bool AspNetUsersExists(string id)
    //    {
    //        return _context.AspNetUsers.Any(e => e.Id == id);
    //    }
    //}
}
