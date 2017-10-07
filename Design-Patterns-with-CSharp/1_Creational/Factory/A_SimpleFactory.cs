using _1_Creational.Factory.Classes;

namespace _1_Creational.Factory
{
    public static class A_SimpleFactory
    {
        public static IBiriyani CreateBiriyani(BiriyaniTypes biriyaniType)
        {
            switch (biriyaniType)
            {
                case BiriyaniTypes.ChikenBiriyani:
                    return new ChikenBiriyani();
                case BiriyaniTypes.FishBiriyani:
                    return new FishBiriyani();
                case BiriyaniTypes.MuttonBiriyani:
                    return new MuttonBiriyani();
                case BiriyaniTypes.VegBiriyani:
                    return new VegBiriyani();
                default:
                    return null;
            }
        }
    }
}
