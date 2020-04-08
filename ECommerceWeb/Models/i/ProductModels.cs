using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerceWeb.Models.i
{
    public class ProductModels
    {
        public DB.Products Product { get; set; }
        public List<DB.Comments> Comments { get; set; }
    }
}