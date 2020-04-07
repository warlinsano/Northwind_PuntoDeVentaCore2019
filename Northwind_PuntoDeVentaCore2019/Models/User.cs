
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind_PuntoDeVentaCore2019.Models
{
    public class User:IdentityUser
    {

        //[NotMapped]
        //public bool Estado { get; set; }

        //[NotMapped]
        //public string[,] todosRoles { get; set; }
    }
}
