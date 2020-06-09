using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using NewService.Models;

namespace NewService.Controllers
{
    public class ProductsController : ApiController
    {
        ProductContext db = new ProductContext();

        public IEnumerable<Product> GetProducts()
        {
            return db.Products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = db.Products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

    }
}