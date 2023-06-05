using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace ThanatosBackend;

public class Startup
{
    public IConfiguration Configuration { get;}
    public IWebHostEnvironment Environment { get;}

    public Startup(IConfiguration configuration, IWebHostEnvironment environment)
    {
        Configuration = configuration;
        Environment = environment;
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApiDescriptionProvider provider)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.Run(async (context)
            =>
        {
            await context.Response.WriteAsync("Hello World!");
        });
    }

    public void ConfigureServices(IServiceCollection services)
    {
        AddControllersAsServices(services);
        AddCustomConfigurations(services);
    }

    private void AddControllersAsServices(IServiceCollection services)
    {
        services
            .AddControllers()
            .AddControllersAsServices();
    }
    private void AddCustomConfigurations(IServiceCollection services)
    {
        services.Configure<ApiBehaviorOptions>(options => options.SuppressModelStateInvalidFilter = true);
    }
}

