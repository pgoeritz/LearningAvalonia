using AvaloniaTutorial.ToDo.Models;
using System.Collections.Generic;

namespace AvaloniaTutorial.ToDo.Services
{
    public class Database
    {
        public IEnumerable<ToDoItem> GetItems() => new[]
        {
            new ToDoItem{Description = "Walk the dog"},
            new ToDoItem{Description = "Buy some milk"},
            new ToDoItem{Description = "Learn Avalonia"}
        };
    }
}
