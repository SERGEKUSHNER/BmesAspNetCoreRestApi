using BmesAspNetCoreRestApi.Messages.DataTransferObjects.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BmesAspNetCoreRestApi.Messages.Response.Brand
{
    public class CreateBrandResponse : ResponseBase
    {
        public BrandDto Brand { get; set; }
        public HttpStatusCode StatusCode { get; internal set; }
    }
}
