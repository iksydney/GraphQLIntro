using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Intro.Business.Repositories;
using GraphQLIntro.Data;
using GraphQLIntro.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace GraphQLIntro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var services = builder.Services;
            var config = builder.Configuration;

            // Add services to the container.

            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.SwaggerExtension();
            services.AddSwaggerGen();

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("SqlServer"));
            });
            services.AddScoped<ISuperHeroeRepository, SuperHeroeRepository>();
            services.AddScoped<ISuperPowerRepository, SuperPowerRepository>();
            services.AddScoped<IMovieRepository, MovieRepository>();

            services.AddGraphQLServer().AddQueryType<Query>()
                //hotchocolate.data nugget manager was used to resolve this error
                .AddProjections()
                .AddFiltering()
                .AddSorting();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(); 
            }
            app.UseHttpsRedirection();

            app.UseAuthorization();
            app.MapControllers();
            app.MapGraphQL("/graphql");

            app.Run();
        }
    }
}