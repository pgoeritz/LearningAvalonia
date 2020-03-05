using System;
using AvaloniaTutorial.ToDo.Models;
using AvaloniaTutorial.ToDo.Services;
using ReactiveUI;
using System.Reactive.Linq;

namespace AvaloniaTutorial.ToDo.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        ViewModelBase _content;

        public MainWindowViewModel(Database database)
        {
            Content = ListVm = new ToDoListViewModel(database.GetItems());
        }

        public ViewModelBase Content
        {
            get => _content;
            private set => this.RaiseAndSetIfChanged(ref _content, value);
        }

        public ToDoListViewModel ListVm { get; }

        public void AddItem()
        {
            var addItemVm = new AddItemViewModel();

            Observable.Merge(
                addItemVm.Ok,
                addItemVm.Cancel.Select(_ => (ToDoItem)null))
                .Take(1)
                .Subscribe(model =>
                {
                    if (model != null)
                        ListVm.Items.Add(model);

                    Content = ListVm;
                });

            Content = addItemVm;
        }
    }
}
