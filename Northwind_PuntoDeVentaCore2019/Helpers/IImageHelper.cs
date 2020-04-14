﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind_PuntoDeVentaCore2019.Helpers
{
   public interface IImageHelper
    {
         Task<string> UploadImageDirectoryAsync(IFormFile imageFile, string folder);

         byte[] UploadImageDB(IFormFile Image);
    }
}
