using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace AzerothAPI.Auth.Utils
{
    public class AddAccessToken : IOperationFilter
    {
        public ConfigurationManager _config { get; }

        public AddAccessToken(ConfigurationManager config)
        {
            _config = config;
        }

        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {

            if (operation.Parameters == null)
                operation.Parameters = new List<OpenApiParameter>();

            var apiKey = _config.GetValue<string>("ApiKey");

            operation.Parameters.Add(new OpenApiParameter()
            {
                Name = "ApiKey",
                Description = "Access Token",
                In = ParameterLocation.Header,
                Required = true,
                Example = new OpenApiString(apiKey)
            });
        }
    }
}