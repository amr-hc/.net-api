
using api.Models;
using api.Repository;
using Microsoft.EntityFrameworkCore;

namespace api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.


            builder.Services.AddDbContext<Mydb>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("cs"));
            }   
            );

            builder.Services.AddCors(
                options =>
                {
                    options.AddPolicy("mypolicy", policy =>
                    {
                        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                    });
                }
                );

            builder.Services.AddScoped<IProductRepository,ProductRepository>();
            builder.Services.AddScoped<ICategoryRepository,CategoryRepository>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors("mypolicy");

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
