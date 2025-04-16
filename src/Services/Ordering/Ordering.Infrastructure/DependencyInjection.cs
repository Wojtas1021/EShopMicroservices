using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ordering.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastuctureServices
        (this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Databaase");

        // add services to the container
        // services.AddDbContext<OrderContext>(options =>
        //     options.UseSqlServer(connectionString));

        // services.AddScoped<IApplicationDbContext, IApplicationDbContext>();

        return services;
    }
}
