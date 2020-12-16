using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationFlowFiltersMiddleware.Services
{
    public class InstanceCounter : IInstanceCounter
    {
        private static int instance;

        public InstanceCounter()
        {
            instance++;
        }

        public int Instances => instance;
    }
}
