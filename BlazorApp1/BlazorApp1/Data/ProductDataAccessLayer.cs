using BlazorApp1.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class ProductDataAccessLayer
    {

        ProductContext db = new ProductContext();
        //To Get all employees details  
        public IEnumerable<Product> GetAllProducts()
        {
            try
            {
                return db.products.ToList();

            }
            catch
            {
                Console.WriteLine("Fehler");
                throw;
            }
        }
    }
}
