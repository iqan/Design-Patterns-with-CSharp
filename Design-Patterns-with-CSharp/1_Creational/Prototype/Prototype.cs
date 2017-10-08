namespace _1_Creational.Prototype
{
    public class Prototype
    {
    }

    public abstract class BiriyaniPrototype
    {
        public bool IsSweet { get; set; }
        public bool IsSpicy { get; set; }
        public bool HasEdibleColor { get; set; }

        public BiriyaniPrototype(bool isSweet, bool isSpicy, bool hasEdibleColor)
        {
            IsSweet = isSweet;
            IsSpicy = isSpicy;
            HasEdibleColor = hasEdibleColor;
        }

        public abstract BiriyaniPrototype Clone();
    }

    public class SweetBiriyani : BiriyaniPrototype
    {
        public SweetBiriyani(bool isSweet = true, bool isSpicy = false, bool hasEdibleColor = false) : 
            base(isSweet, isSpicy, hasEdibleColor)
        {
        }

        public override BiriyaniPrototype Clone()
        {
            return (SweetBiriyani) this.MemberwiseClone();
        }
    }

    public class SpicyBiriyani : BiriyaniPrototype
    {
        public SpicyBiriyani(bool isSweet = false, bool isSpicy = true, bool hasEdibleColor = false) :
            base(isSweet, isSpicy, hasEdibleColor)
        {
        }

        public override BiriyaniPrototype Clone()
        {
            return (SpicyBiriyani)this.MemberwiseClone();
        }
    }

    public class RamboBiriyani : BiriyaniPrototype
    {
        public RamboBiriyani(bool isSweet = false, bool isSpicy = false, bool hasEdibleColor = true) :
            base(isSweet, isSpicy, hasEdibleColor)
        {
        }

        public override BiriyaniPrototype Clone()
        {
            return (RamboBiriyani)this.MemberwiseClone();
        }
    }
}
