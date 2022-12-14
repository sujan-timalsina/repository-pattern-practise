using TodoApp.Repository.Domain;

namespace TodoApp.Repository.RTodoItem;

public class TodoItemRepository : GenericRepository<TodoItem>, ITodoItemRepository
{
    public TodoItemRepository(TodoAppContext dbContext)
    {
        DbContext = dbContext;
    }
}