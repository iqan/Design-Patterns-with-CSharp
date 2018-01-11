using _1_Creational.Factory.Classes;

namespace _1_Creational.Factory
{
    public static class B_AbstractFactory
    {

    }

    public abstract class BiriyaniFactory
    {
        public abstract IBiriyani CreateVegBiriyani();
        public abstract IBiriyani CreateNonVegBiriyani();
    }

    public class SimpleBiriyaniFactory : BiriyaniFactory
    {
        public override IBiriyani CreateVegBiriyani()
        {
            return new VegBiriyani();
        }

        public override IBiriyani CreateNonVegBiriyani()
        {
            return new ChickenBiriyani();
        }
    }

    public class SpecialBiriyaniFactory : BiriyaniFactory
    {
        public override IBiriyani CreateVegBiriyani()
        {
            return new VegBiriyani();
        }

        public override IBiriyani CreateNonVegBiriyani()
        {
            return new MuttonBiriyani();
        }
    }
}
