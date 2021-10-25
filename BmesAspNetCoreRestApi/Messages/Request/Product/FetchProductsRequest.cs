using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmesAspNetCoreRestApi.Messages.Request.Product
{
    public class FetchProductsRequest
    {
        public int PageNumber { get; set; }
        public int ProductsPerPage { get; set; }
        public string CategorySlug { get; set; }
        public string BrandSlug { get; set; }
    }
}
