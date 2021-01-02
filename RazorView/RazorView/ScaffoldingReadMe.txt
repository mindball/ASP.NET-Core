Support for ASP.NET Core Identity was added to your project.

For setup and configuration information, see https://go.microsoft.com/fwlink/?linkid=2116645.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationFlowFiltersMiddleware.Services
{
    public interface IInstanceSingletonCounter
    {
        int Instances { get; }        
    }
}
