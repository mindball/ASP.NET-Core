using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationFlowFiltersMiddleware.Services
{
    public interface IInstanceCounter
    {
        int Instances { get; }
    }
}
