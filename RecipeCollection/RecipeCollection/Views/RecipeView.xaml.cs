using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace RecipeCollection.Views
{
    public class RecipeView : UserControl
    {
        public RecipeView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
