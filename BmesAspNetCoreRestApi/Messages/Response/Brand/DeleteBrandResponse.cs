using BmesAspNetCoreRestApi.Messages.DataTransferObjects.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmesAspNetCoreRestApi.Messages.Response.Brand
{
    public class DeleteBrandResponse
    {
        public BrandDto Brand { get; set; }
    }
}
