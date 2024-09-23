using Microsoft.EntityFrameworkCore;
using todo.Entity;
using todo.Repository;

namespace todo.DBContext;

public class ApiDbContext : DbContext
{
    protected override void OnConfiguring
        (DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase(databaseName: "TodoDB");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Todo>().HasKey(t => t.Id);
    }

    public DbSet<Todo> Todos { get; set; }
    public DbSet<User> Users { get; set; }
}