using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostGreetest.Data
{
    public class DataModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<TestModel> TestsModel { get; set; } = new List<TestModel>();
    }
}
