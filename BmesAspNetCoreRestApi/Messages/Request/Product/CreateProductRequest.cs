﻿using BmesAspNetCoreRestApi.Messages.DataTransferObjects.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmesAspNetCoreRestApi.Messages.Request.Product
{
    public class CreateProductRequest
    {
        public ProductDto Product { get; set; }
    }
}
