using Microsoft.EntityFrameworkCore;
using TodoApp.Repository.Domain;
namespace TodoApp.Repository;
public class TodoAppContext : DbContext
{

    public TodoAppContext(DbContextOptions<TodoAppContext> options) : base(options)
    {
    }
    public DbSet<TodoItem> TodoItems { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

}