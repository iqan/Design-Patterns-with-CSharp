using System.Collections.Generic;

namespace _3_Structural.Decorator
{
    public class BiriyaniWithExtraSpicies : IBiriyani
    {
        public decimal Cost { get; set; }
        public List<string> Ingredients { get; set; }

        public BiriyaniWithExtraSpicies(IBiriyani biriyani)
        {
            Cost = biriyani.Cost + 25;
            Ingredients = new List<string>();
            Ingredients.AddRange(biriyani.Ingredients);

            // Extra spices
            Ingredients.Add("Special Spicies");
        }
    }
}
