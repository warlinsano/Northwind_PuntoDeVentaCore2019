using Microsoft.AspNetCore.Identity;
using Northwind_PuntoDeVentaCore2019.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind_PuntoDeVentaCore2019.Helpers
{
    public class UserHelper : IUserHelper
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserHelper(
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IdentityUser>GetUsersByEmialAsync(string email)
        {
            //var user = user(IdentityUser);
            return await _userManager.FindByEmailAsync(email);
        }

        public async Task<IdentityUser> GetUsersByIdAsync(string id)
        {
            return await _userManager.FindByIdAsync(id);
        }

    }
}
