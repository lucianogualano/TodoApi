using Microsoft.EntityFrameworkCore;
using TodoApi.DTO;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }

        public DbSet<TodoApi.DTO.TodoItemDTO> TodoItemDTO { get; set; }
    }
}
