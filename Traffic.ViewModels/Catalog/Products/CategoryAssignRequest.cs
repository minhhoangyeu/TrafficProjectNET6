using System;
using System.Collections.Generic;
using System.Text;
using Traffic.ViewModels.Common;

namespace Traffic.ViewModels.Catalog.Products
{
    public class CategoryAssignRequest
    {
        public int Id { get; set; }
        public List<SelectItem> Categories { get; set; } = new List<SelectItem>();
    }
}