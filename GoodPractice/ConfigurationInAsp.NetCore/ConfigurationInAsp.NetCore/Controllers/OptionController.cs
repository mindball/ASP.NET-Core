using ConfigurationInAsp.NetCore.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace ConfigurationInAsp.NetCore.Controllers
{
    public class OptionController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly PositionOptions _options;

        public OptionController(IConfiguration configuration,
            IOptions<PositionOptions> options)
        {
            this.configuration = configuration;
            this._options = options.Value;
        }

        public IActionResult Index()
        {
            var positionOptions = new PositionOptions();
            this.configuration.GetSection(PositionOptions.Position).Bind(positionOptions);

            return Content($"Title: {positionOptions.Title} \n" +
                           $"Name: {positionOptions.Name}");
        }

        public IActionResult UseDi()
        {
            return Content($"Title: {_options.Title} \n" +
                       $"Name: {_options.Name}");
        }
    }
}
