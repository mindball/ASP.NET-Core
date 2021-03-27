using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Demo.Controllers
{
    public class HttpVerbController : BaseController
    {
        [HttpGet(Name = "Products_List")]   // GET /api/HttpVerb
        public string ListProducts()
        {
            return nameof(ListProducts);
        }

        [HttpGet("{id}")]   // GET /api/HttpVerb/xyz
        public string GetProduct(string id)
        {
            return $"/api/{nameof(GetProduct)}/{id}";
        }

        [HttpGet("int/{id:int}")] // GET /api/HttpVerb/int/3
        public string GetIntProduct(int id)
        {
            return $"/api/te{nameof(GetIntProduct)}/int/{id} constraint";
        }

        [HttpGet("int2/{id}")]  // GET /api/HttpVerb/int2/3
        public string GetInt2Product(int id)
        {
            return $"/api/test2/int2/{id}";
        }
    }
}
