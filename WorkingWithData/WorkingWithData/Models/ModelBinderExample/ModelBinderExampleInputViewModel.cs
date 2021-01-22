using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using WorkingWithData.ModelBinders;

namespace WorkingWithData.Models.ModelBinderExample
{
    public class ModelBinderExampleInputViewModel
    {
        public string Name { get; set; }

        public DateTime Date { get; set; }

        //Custom modelbinder:
        //Request: https://localhost:5001/modelbinderexample/custombinder?name=test&date=01.01.2021
        //Ако в request има параметер с year-name се взима предвид Custom-binding-a
        //Result: {"name":"test","date":"2021-01-01T00:00:00","year":2021}
        //[ModelBinder(BinderType =typeof(GetYearBinder))]        
        public int Year { get; set; }

        //Global modelbinder
        public int YearGlobal { get; set; }
    }
}
