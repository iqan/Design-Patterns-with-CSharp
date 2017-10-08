using System.Collections.Generic;

namespace _1_Creational.Builder.Classes
{
    public class Biriyani
    {
        private List<string> _receipeSteps = new List<string>();

        public void AddStep(string step)
        {
            _receipeSteps.Add(step);
        }

        public string ShowSteps()
        {
            return string.Join(" ", _receipeSteps);
        }
    }
}
