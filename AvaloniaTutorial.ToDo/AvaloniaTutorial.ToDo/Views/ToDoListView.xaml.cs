using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaTutorial.ToDo.Views
{
    public class ToDoListView : UserControl
    {
        public ToDoListView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
