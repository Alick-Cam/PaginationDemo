using Microsoft.EntityFrameworkCore;
using Pagination.Demo.Data;
using System.Reflection;

namespace Pagination.Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen( c =>
                c.EnableAnnotations()
            );

            builder.Services.AddRouting(options => options.LowercaseUrls = true);

            builder.Services.AddDbContext<CarDbContext>(optionsBuilder => optionsBuilder.UseSqlite("Data Source=./Data/Database/pagination-demo.db"));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
