using CacheDemo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace CacheDemo.Controllers
{
    public class CacheController : Controller
    {
        private const string cacheKey = "New";
        private static int count = 0;
        private readonly ApplicationDbContext context;
        private IMemoryCache cache;

        public CacheController(ApplicationDbContext context, 
            IMemoryCache cache)
        {
            this.context = context;
            this.cache = cache;
        }

        public IActionResult IMemoryCache()
        {
            //Vehicles must not delete from db only create (see case when vehicle is edited)
            var countRecords = this.context.Cars.Count();
            var hasNewRecordInDB = countRecords > count;

            if(countRecords <= 0 )
            {
                return this.Content("Not exist records");
            }

            if (hasNewRecordInDB)
            {
                count = countRecords;
                var allCars = this.context.Cars.Select(c => c).ToList();
                var result = JsonConvert.SerializeObject(allCars, Formatting.Indented);
                this.cache.Set<string>(cacheKey, result.ToString());
            }

            if(this.cache.TryGetValue(cacheKey, out var value))
            {
                return this.Content(value.ToString());
            }

            return this.Content(countRecords.ToString()); 
        }

        public IActionResult TagHelperCache()
        {
            return this.View();
        }

        [ResponseCache(Duration = 120, Location = ResponseCacheLocation.Any)]
        public IActionResult ResponseCacheTest()
        {
            //В response се появават response header: cache-control: private,max-age=120
            /* Ако заредим този action в response ще се появи header cache-control
             * Ако след това посетим друга страница ще посетим наново https://localhost:5001/imemorycache/ResponseCache
             * с нова заявка, нищо няма дасе кешира защото сървърат отговаря, но ако се върнем с бутона back
             * тогава browser-a ще вземе кеша от диска. Пробвах с chrome не става с edge става.
             * 
             * 
             * 
             * 
             */
            return this.Content(DateTime.Now.ToString());
        }
    }
}
