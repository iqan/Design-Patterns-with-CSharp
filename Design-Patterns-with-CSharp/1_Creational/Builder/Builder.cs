using _1_Creational.Builder.Classes;

namespace _1_Creational.Builder
{
    public class Builder
    {
        private readonly BiriyaniReciepe _receipe;

        public Builder(BiriyaniReciepe receipe)
        {
            _receipe = receipe;
        }

        public void Build()
        {
            _receipe.Prepare();
            _receipe.Cook();
        }
    }

    public abstract class BiriyaniReciepe
    {
        public abstract void Prepare();
        public abstract void Cook();

        public abstract Biriyani GetBiriyani();
    }

    public class SimpleBiriyaniReciepe : BiriyaniReciepe
    {
        private Biriyani _biriyani = new Biriyani();

        public override void Prepare()
        {
            _biriyani.AddStep("Simple preparation step.");
        }

        public override void Cook()
        {
            _biriyani.AddStep("Simple cooking step.");
        }

        public override Biriyani GetBiriyani()
        {
            return _biriyani;
        }
    }

    public class SpecialBiriyaniReciepe : BiriyaniReciepe
    {
        private Biriyani _biriyani = new Biriyani();

        public override void Prepare()
        {
            _biriyani.AddStep("Special preparation step.");
        }

        public override void Cook()
        {
            _biriyani.AddStep("Special cooking step.");
        }

        public override Biriyani GetBiriyani()
        {
            return _biriyani;
        }
    }
}
