using Microsoft.EntityFrameworkCore;
using Authors.Application.Interfaces;
using Authors.Persistence.Repositories;

namespace Authors.Persistence;

public static class PersistenceInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.AddDbContext<AuthorDbContext>(
            optionsBuilder =>
            {
                optionsBuilder.EnableSensitiveDataLogging();
                optionsBuilder.EnableDetailedErrors();
                optionsBuilder.UseNpgsql(configuration.GetConnectionString("library-dev") + "Database=authors_dev;");
                AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            },
            ServiceLifetime.Transient
        );

        serviceCollection.AddScoped<IAuthorRepository, AuthorRepository>();
        return serviceCollection;
    }
}
