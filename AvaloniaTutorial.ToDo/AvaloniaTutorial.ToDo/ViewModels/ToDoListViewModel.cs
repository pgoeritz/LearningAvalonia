using AvaloniaTutorial.ToDo.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AvaloniaTutorial.ToDo.ViewModels
{
    public class ToDoListViewModel : ViewModelBase
    {
        public ToDoListViewModel(IEnumerable<ToDoItem> toDoItems)
        {
            Items = new ObservableCollection<ToDoItem>(toDoItems);
        }

        public ObservableCollection<ToDoItem> Items { get; }
    }
}
