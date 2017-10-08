using System.Collections.Generic;

namespace _3_Structural.Decorator
{
    public interface IBiriyani
    {
        decimal Cost { get; set; }
        
        List<string> Ingredients { get; set; }
    }

    public class SimpleChickenBiriyani : IBiriyani
    {
        public decimal Cost { get; set; }
        public List<string> Ingredients { get; set; }

        public SimpleChickenBiriyani()
        {
            Cost = 250;
            Ingredients = new List<string>
            {
                "Rice",
                "Chicken"
            };
        }
    }
}
