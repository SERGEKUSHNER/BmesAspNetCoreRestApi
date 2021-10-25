using BmesAspNetCoreRestApi.Messages.Request.Product;
using BmesAspNetCoreRestApi.Messages.Response.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmesAspNetCoreRestApi.Services
{
    public interface ICatalogueService
    {
        FetchProductResponse FetchProducts(FetchProductsRequest fetchProductsRequest);
    }
}
