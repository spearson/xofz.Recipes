namespace xofz.Recipes.Framework
{
    using System.Collections.Generic;
    using System.IO;
    using xofz.Framework.Materialization;

    public class RecipeManager : RecipeSaver, RecipeLoader
    {
        public RecipeManager(string location)
        {
            this.location = location;
        }

        bool RecipeSaver.Save(Recipe recipe)
        {
            if (!Directory.Exists(this.location))
            {
                Directory.CreateDirectory(this.location);
            }

            var lines = new List<string>();
            lines.Add("[Description]");
            if (recipe.Description != null)
            {
                lines.Add(recipe.Description);
            }
            lines.Add(string.Empty);

            lines.Add("[Ingredients]");
            if (recipe.Ingredients != null)
            {
                lines.AddRange(recipe.Ingredients);
            }
            lines.Add(string.Empty);

            lines.Add("[Directions]");
            if (recipe.Directions != null)
            {
                lines.AddRange(recipe.Directions);
            }

            var recipeLocation = Path.Combine(this.location, recipe.Name);
            var updated = File.Exists(recipeLocation);

            File.WriteAllLines(
                Path.Combine(this.location, recipe.Name),
                lines);

            return updated;
        }

        void RecipeSaver.Delete(string recipeName)
        {
            var filePath = Path.Combine(this.location, recipeName);
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        IEnumerable<Recipe> RecipeLoader.All()
        {
            if (!Directory.Exists(this.location))
            {
                Directory.CreateDirectory(this.location);
            }

            foreach (var filePath in Directory.GetFiles(this.location))
            {
                var name = Path.GetFileName(filePath);
                var lines = File.ReadAllLines(filePath);
                if (lines.Length <= 5)
                {
                    yield return new Recipe
                    {
                        Name = name
                    };
                }

                var description = lines[1];
                var indexOfIngredients = lines.Length;
                for (var i = 2; i < lines.Length; ++i)
                {
                    if (lines[i] == "[Ingredients]")
                    {
                        indexOfIngredients = i + 1;
                        break;
                    }
                }

                var indexOfDirections = lines.Length;
                var ingredients = new LinkedList<string>();
                for (var i = indexOfIngredients; i < lines.Length - 1; ++i)
                {
                    if (lines[i] == string.Empty && lines[i + 1] == "[Directions]")
                    {
                        indexOfDirections = i + 2;
                        break;
                    }

                    ingredients.AddLast(lines[i]);
                }

                var directions = new LinkedList<string>();
                for (var i = indexOfDirections; i < lines.Length; ++i)
                {
                    directions.AddLast(lines[i]);
                }

                yield return new Recipe
                {
                    Name = name,
                    Description = description,
                    Ingredients = new LinkedListMaterializedEnumerable<string>(
                        ingredients),
                    Directions = new LinkedListMaterializedEnumerable<string>(
                        directions)
                };
            }
        }

        private readonly string location;
    }
}
