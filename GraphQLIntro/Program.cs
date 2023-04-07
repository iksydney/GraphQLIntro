using GraphQL.Intro.Business.Repositories;
using GraphQLIntro.Data;
using GraphQLIntro.Extensions;
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

            services.AddGraphQLServer().AddQueryType<Query>;

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

            app.Run();
        }
    }
}