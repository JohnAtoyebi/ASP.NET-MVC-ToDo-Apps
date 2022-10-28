using System.ComponentModel.DataAnnotations;

namespace TODO_LIST.Models
{
    public class TodoList
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
    }
}
