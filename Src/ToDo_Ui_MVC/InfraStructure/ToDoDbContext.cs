
using Microsoft.EntityFrameworkCore;

public class ToDoDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<TodoItem> TodoItems { get; set; }
    public DbSet<Category> Categories { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-A0067M7\\SQLEXPRESS;Initial Catalog=ToDoList19;Integrated Security=True;Trust Server Certificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfig());
        modelBuilder.ApplyConfiguration(new TodoConfig());
        modelBuilder.ApplyConfiguration(new CategoryConfig());

        modelBuilder.Entity<Category>().HasData(new Category { Id = 1, Title = "شخصی" },
            new Category { Id = 2, Title = "کاری" }, new Category { Id = 3, Title = "دانشگاهی" },
                        new Category { Id = 4, Title = "سایر" });

    }

}



