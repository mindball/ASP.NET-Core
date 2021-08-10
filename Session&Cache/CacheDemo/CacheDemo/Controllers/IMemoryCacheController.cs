using CacheDemo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using System.Linq;

namespace CacheDemo.Controllers
{
    public class IMemoryCacheController : Controller
    {
        private const string cacheKey = "New";
        private static int count = 0;
        private readonly ApplicationDbContext context;
        private IMemoryCache cache;

        public IMemoryCacheController(ApplicationDbContext context, 
            IMemoryCache cache)
        {
            this.context = context;
            this.cache = cache;
        }

        public IActionResult Index()
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
    }
}
