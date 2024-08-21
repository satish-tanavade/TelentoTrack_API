
using Microsoft.EntityFrameworkCore;
using TalentoTrack.Common.Repositoy;
using TalentoTrack.Common.Services;
using TalentoTrack.Dao.Db;
using TalentoTrack.Dao.Repository;
using TalentoTrack.Services;

namespace TalentoTrack_API
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
            builder.Services.AddSwaggerGen();
            
            builder.Services.AddScoped<IAccountService, AccountService>();
            builder.Services.AddTransient<IAccountRepository, AccountRepository>();

            builder.Services.AddDbContext<TalentoTrack_DbContext>(option => option.UseSqlServer(builder.Configuration["ConnectionStrings:dbConnectionString"]));

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
