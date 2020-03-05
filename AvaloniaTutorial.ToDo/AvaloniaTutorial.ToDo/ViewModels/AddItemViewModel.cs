using AvaloniaTutorial.ToDo.Models;
using ReactiveUI;
using System.Reactive;

namespace AvaloniaTutorial.ToDo.ViewModels
{
    public class AddItemViewModel : ViewModelBase
    {
        string _description;

        public AddItemViewModel()
        {
            var okEnabled = this.WhenAnyValue(
                x => x.Description,
                x => !string.IsNullOrWhiteSpace(x));

            Ok = ReactiveCommand.Create(() => new ToDoItem { Description = Description }, okEnabled);
            Cancel = ReactiveCommand.Create(() => { });
        }

        public string Description
        {
            get => _description;
            set => this.RaiseAndSetIfChanged(ref _description, value);
        }

        public ReactiveCommand<Unit, ToDoItem> Ok { get; }
        public ReactiveCommand<Unit, Unit> Cancel { get; }
    }
}
