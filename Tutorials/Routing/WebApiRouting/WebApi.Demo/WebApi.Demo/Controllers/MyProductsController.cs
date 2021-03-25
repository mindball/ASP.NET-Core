using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Demo.Controllers
{
    public class MyProductsController : BaseController
    {
        //https://localhost:5001/products3 with get method
        [HttpGet("/products3")]
        public string ListProducts()
        {
            return "products3";
        }

        //https://localhost:5001/products3 with post method and body "id": "test"
        [HttpPost("/products3")]
        public string CreateProduct(MyProduct myProduct)
        {
            return nameof(CreateProduct);
        }
    }

    public class MyProduct
    {
        public string Id { get; set; }

    }
}
