using Microsoft.EntityFrameworkCore;

namespace Thanatos.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddDbContext<ThanatosDbContext>(OptionsBuilderConfigurationExtensions =>
                OptionsBuilderConfigurationExtensions.UseSqlServer(
                    builder.Configuration.GetConnectionString("DbConnection")
                )
            );
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                // Apply pending migrations
                using (var scope = app.Services.CreateScope())
                {
                    var serviceProvider = scope.ServiceProvider;
                    var dbContext = serviceProvider.GetRequiredService<ThanatosDbContext>();
                    dbContext.Database.Migrate();
                }

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