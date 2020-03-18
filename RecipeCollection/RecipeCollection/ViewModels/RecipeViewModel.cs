using RecipeCollection.Models;
using System.Collections.ObjectModel;

namespace RecipeCollection.ViewModels
{
    class RecipeViewModel
    {
        Recipe _recipe;

        public string Title
        {
            get { return _recipe.Name; }
            set { _recipe.Name = value; }
        }

        public string Description
        {
            get { return _recipe.Description; }
            set { _recipe.Description = value; }
        }

        public ObservableCollection<IngredientViewModel> IngredientViewModels { get; set; }
    }
}
