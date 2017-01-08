namespace xofz.Recipes.Framework
{
    using System.Collections.Generic;

    public interface RecipeLoader
    {
        IEnumerable<Recipe> All();
    }
}
