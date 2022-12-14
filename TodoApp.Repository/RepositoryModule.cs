using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TodoApp.Repository.RTodoItem;
namespace TodoApp.Repository;
public static class RepositoryModule
{
    public static void Register(IServiceCollection services, string connection, string migrationsAssembly)
    {
        services.AddDbContext<TodoAppContext>(options => options.UseSqlite(connection, builder => builder.MigrationsAssembly(migrationsAssembly)));
        services.AddTransient<ITodoItemRepository, TodoItemRepository>();

    }
}