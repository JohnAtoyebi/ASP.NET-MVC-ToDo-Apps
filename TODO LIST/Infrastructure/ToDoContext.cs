using Microsoft.EntityFrameworkCore;
using TODO_LIST.Models;

namespace TODO_LIST.Infrastructure
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options)
            : base(options)
        {

        }

        public DbSet<TodoList> ToDoList { get; set; }

    }
}
