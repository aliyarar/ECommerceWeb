using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerceWeb.Models.i
{
    public class BasketModels
    {
        public DB.Products Product { get; set; }
        public int Count { get; set; }
    }
}