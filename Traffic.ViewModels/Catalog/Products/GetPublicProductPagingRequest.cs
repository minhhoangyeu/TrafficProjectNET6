using System;
using System.Collections.Generic;
using System.Text;
using Traffic.ViewModels.Common;

namespace Traffic.ViewModels.Catalog.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}