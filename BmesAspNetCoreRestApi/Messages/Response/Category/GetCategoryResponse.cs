using BmesAspNetCoreRestApi.Messages.DataTransferObjects.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmesAspNetCoreRestApi.Messages.Response.Category
{
    public class GetCategoryResponse : ResponseBase
    {
        public CategoryDto Category { get; set; }
    }
}
