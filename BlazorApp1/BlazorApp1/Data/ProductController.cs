using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp1.Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Data
{
    public class ProductController: Controller
    {
        ProductDataAccessLayer products_layer = new ProductDataAccessLayer(); 

        [HttpGet] 
        [Route("api/Product/Index")] 
        public IEnumerable<Product> Index() 
        { 
            return products_layer.GetAllProducts(); 
        } 
    }
}
