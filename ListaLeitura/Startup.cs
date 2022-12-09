using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc();
    }
    public void configure(IApplicationBuilder applicationBuilder)
    {
        applicationBuilder.UseDeveloperExceptionPage();
        applicationBuilder.UseMvcWithDefaultRoute();
    }
}
