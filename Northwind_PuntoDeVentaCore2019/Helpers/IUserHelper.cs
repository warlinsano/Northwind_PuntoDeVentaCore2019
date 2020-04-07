using Microsoft.AspNetCore.Identity;
using Northwind_PuntoDeVentaCore2019.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind_PuntoDeVentaCore2019.Helpers
{
   public interface IUserHelper
    {
        Task<IdentityUser> GetUsersByEmialAsync(string email);

        Task<IdentityUser> GetUsersByIdAsync(string id);

    }
}
