namespace xofz.Recipes
{
    public class Recipe
    {
        public virtual string Name { get; set; }

        public virtual string Description { get; set; }

        public virtual MaterializedEnumerable<string> Ingredients { get; set; }

        public virtual MaterializedEnumerable<string> Directions { get; set; }

        public override int GetHashCode()
        {
            return 0;
        }

        public override bool Equals(object other)
        {
            if (!(other is Recipe))
            {
                return false;
            }

            var otherRecipe = (Recipe)other;
            return this.Name == otherRecipe.Name;
        }
    }
}
