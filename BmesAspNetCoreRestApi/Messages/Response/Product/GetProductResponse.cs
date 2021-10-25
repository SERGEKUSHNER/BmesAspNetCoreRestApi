using BmesAspNetCoreRestApi.Messages.DataTransferObjects.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmesAspNetCoreRestApi.Messages.Response.Product
{
    public class GetProductResponse : ResponseBase
    {
        public ProductDto Product { get; set; }
    }
}
