using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TodoApp.Repository.RTodoItem;
namespace TodoApp.Repository;
public static class RepositoryModule
{
    public static void Register(IServiceCollection services)
    {
        string migrationsAssembly = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;

        services.AddDbContext<TodoAppContext>(options => options.UseSqlServer(
            @"Server=DESKTOP-13L30S5\SQLEXPRESS;Initial Catalog=samaj_db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False",
            builder => builder.MigrationsAssembly(migrationsAssembly)
        ));
        services.AddTransient<ITodoItemRepository, TodoItemRepository>();

    }
}