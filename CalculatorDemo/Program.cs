using Calculator;
using CalculatorDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace MyNamespace
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            var builder = WebApplication.CreateBuilder();            

            builder.Services.AddControllers();
            builder.Services.AddDbContext<DBCalculationsContext>(options =>
               options.UseSqlServer(builder.Configuration.GetConnectionString("DBContext")));
                        

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: "calculationsservice",
                                  builder =>
                                  {
                                      builder.AllowAnyOrigin().AllowAnyHeader()
                                                  .AllowAnyMethod(); ;
                                  });
            });

            var app = builder.Build();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.UseCors("calculationsservice");

            app.Run();                        

        }
       
    }

   
}

