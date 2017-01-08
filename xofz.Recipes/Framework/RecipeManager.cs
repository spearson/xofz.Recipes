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
            lines.Add(recipe.Description);
            lines.Add(string.Empty);
            foreach (var ingredient in recipe.Ingredients)
            {
                lines.Add(ingredient);
            }
            lines.Add(string.Empty);

            foreach (var direction in recipe.Directions)
            {
                lines.Add(direction);
            }

            var recipeLocation = Path.Combine(this.location, recipe.Name);
            var updated = File.Exists(recipeLocation);

            File.WriteAllLines(
                Path.Combine(this.location, recipe.Name),
                lines);

            return updated;
        }

        public IEnumerable<Recipe> All()
        {
            foreach (var filePath in Directory.GetFiles(this.location))
            {
                var name = Path.GetFileName(filePath);
                var lines = File.ReadAllLines(filePath);
                if (lines.Length < 1)
                {
                    continue;
                }

                var description = lines[0];
                if (lines.Length < 3)
                {
                    yield return new Recipe
                    {
                        Name = name,
                        Description = description
                    };
                }

                var ingredients = new LinkedList<string>();
                var endOfIngredients = lines.Length;
                for (var i = 2; i < lines.Length; ++i)
                {
                    if (lines[i] == string.Empty)
                    {
                        endOfIngredients = i;
                        break;
                    }

                    ingredients.AddLast(lines[i]);
                }

                if (endOfIngredients == lines.Length)
                {
                    yield return new Recipe
                    {
                        Name = name,
                        Description = description,
                        Ingredients =
                            new LinkedListMaterializedEnumerable<string>(ingredients)
                    };
                }

                var directions = new LinkedList<string>();
                for (var i = endOfIngredients + 1; i < lines.Length; ++i)
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
