using System.Collections.Generic;

namespace _3_Structural.Decorator
{
    public class ChickenBiriyaniWithExtraWings : IBiriyani
    {
        public decimal Cost { get; set; }
        public List<string> Ingredients { get; set; }

        public ChickenBiriyaniWithExtraWings(IBiriyani biriyani)
        {
            Cost = biriyani.Cost + 50;
            Ingredients = new List<string>();
            Ingredients.AddRange(biriyani.Ingredients);

            // Extra chicken wings
            Ingredients.Add("Chicken Wings");
        }
    }
}
