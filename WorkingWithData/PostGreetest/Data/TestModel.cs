using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostGreetest.Data
{
    public class TestModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int DataModelId { get; set; }

        public DataModel DataModel { get; set; }
    }
}
