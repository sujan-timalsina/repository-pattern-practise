using Microsoft.EntityFrameworkCore;
using TodoApp.Repository.Domain;
namespace TodoApp.Repository;
public class TodoAppContext : DbContext
{

    public TodoAppContext(DbContextOptions<TodoAppContext> options) : base(options)
    {
    }

    /*
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string migrationsAssembly = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
        optionsBuilder.UseSqlServer(
            @"Server=DESKTOP-13L30S5\\SQLEXPRESS;Initial Catalog=samaj_db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False",
            builder => builder.MigrationsAssembly(migrationsAssembly)
        );
    }
    */

    public DbSet<TodoItem> TodoItems { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

}