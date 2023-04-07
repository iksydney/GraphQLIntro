﻿using Microsoft.OpenApi.Models;

namespace GraphQLIntro.Extensions
{
    public static class SwaggerServiceExtension
    {
        public static IServiceCollection SwaggerExtension(this IServiceCollection services)
        {
            services.AddSwaggerGen(opt =>
            {
                opt.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Power House",
                    Version = "V1"
                });
            });
            return services;
        }
        public static IApplicationBuilder SwaggerDocumentation(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1"));

            return app;
        }
    }
}
