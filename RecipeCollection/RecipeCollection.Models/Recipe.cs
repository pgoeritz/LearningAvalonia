using System.Collections.ObjectModel;

namespace RecipeCollection.Models
{
    public class Recipe
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ObservableCollection<IngredientAmount> Ingredients { get; set; }
    }
}
