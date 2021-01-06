using Microsoft.AspNetCore.Mvc;
using RepositoryServicePatternDemo.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryServicePattern.Web.ViewComponents
{
    public class FinancialStatsViewComponent : ViewComponent
    {
        private readonly IFinancialsService financialService;

        public FinancialStatsViewComponent(IFinancialsService financialService)
        {
            this.financialService = financialService;
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            var stats = this.financialService.GetStats();

            return Task.FromResult<IViewComponentResult>(View(stats));
        }
    }
}
