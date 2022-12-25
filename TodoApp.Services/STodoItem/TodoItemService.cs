using TodoApp.Repository.Domain;
using TodoApp.Repository.RTodoItem;
namespace TodoApp.Services.STodoItem;
public class TodoItemService : GenericService<TodoItem>, ITodoItemService
{
    public TodoItemService(ITodoItemRepository todoItemRepository) : base(todoItemRepository)
    {
    }
}
