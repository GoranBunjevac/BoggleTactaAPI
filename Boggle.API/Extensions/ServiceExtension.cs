using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Boggle.API.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            // Register the Swagger Generator service. This service is responsible for genrating Swagger Documents.
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Swagger Boggle API",
                    Version = "v1"
                });
            });
        }
    }
}
