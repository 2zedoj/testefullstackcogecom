
using API_Cadastro.Context;
using API_Cadastro.Views.Repository;
using API_Cadastro.Views.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace API_Cadastro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var startup = new Startup(builder.Configuration);
            startup.ConfigureServices(builder.Services);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddEntityFrameworkSqlServer()
                .AddDbContext<IRoundTheCodeEfCoreDbContext,ConnectionContext>(
                    options => options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"))
                );
            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<IRoundTheCodeEfCoreDbContext>();

                if (!dbContext.Database.CanConnect())
                {
                    throw new NotImplementedException("Can't Connect to DB");
                }
            }
                startup.Configure(app, builder.Environment);

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
