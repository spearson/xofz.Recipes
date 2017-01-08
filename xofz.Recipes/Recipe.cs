namespace xofz.Recipes
{
    public class Recipe
    {
        public virtual string Name { get; set; }

        public virtual string Description { get; set; }

        public virtual MaterializedEnumerable<string> Ingredients { get; set; }

        public virtual MaterializedEnumerable<string> Directions { get; set; }
    }
}
