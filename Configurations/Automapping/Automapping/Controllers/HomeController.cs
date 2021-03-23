using AutoMapper;
using AutoMapper.QueryableExtensions;
using Automapping.Data;
using Automapping.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Linq;


namespace Automapping.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly TestDbContext context;
        //When not in context in LINQ
        private readonly IMapper mapper;

        public HomeController(TestDbContext context,
            IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            //basic match properties names mappings without interface with/without custom map(see ctor AutoMapperProfile)            
            //var ordinaryMapping = this.context
            //   .Persons
            //   .ProjectTo<Services.Models.PersonCustomServiceModel>()
            //   .ToList();
            
            ////map on linq 
            //var persons = this.context
            //    .Persons
            //    .ProjectTo<Services.Models.BaseMapping.PersonCustomServiceModel >()
            //    .ToList();

            //CustomMapping with Reflection
            var customPersons = this.context
                .Persons
                .ProjectTo<Services.Models.CustomeMapping.PersonCustomServiceModel>()
                .ToList();

            //object who is not of linq context example
            MapOutterObject();

            return this.View();
        }

        private void MapOutterObject()
        {
            //Edit type
            var person = new Person { PersonId = 105, FirstName = "test", Salary = 200 };
           
            var mappedObject = this.mapper.Map<SomeObject>(person);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    internal class SomeObject
    {
        public int PersonId { get; set; }

        public string FirstName { get; set; }

        public decimal Salary { get; set; }
    }
}
