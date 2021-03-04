using GlobalErrorHandlingByCodeMaze.DataModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace GlobalErrorHandlingByCodeMaze.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesWithoutTryCatchController : Controller
    {
        
        [HttpGet]
        public IActionResult Get()
        {
            var students = new List<Student>()
                {
                    new Student(){ Name = "Ivan", Age = 16, Gender ="male"},
                    new Student(){ Name = "Drago", Age = 26, Gender ="male"},
                    new Student(){ Name = "Vesi", Age = 28, Gender ="female"}
                }; //simulation for the data base access

                throw new Exception("Exception while fetching all the students from the storage.");

                return Ok(students);                        
        }
    }
}
