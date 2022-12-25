using Microsoft.Extensions.DependencyInjection;
using TodoApp.Services.STodoItem;
namespace TodoApp.Services;
public static class ServicesModule
{
    public static void Register(IServiceCollection services)
    {
        services.AddTransient<ITodoItemService, TodoItemService>();
    }
}