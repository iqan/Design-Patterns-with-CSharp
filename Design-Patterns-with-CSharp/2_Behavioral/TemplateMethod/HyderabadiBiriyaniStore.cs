namespace _2_Behavioral.TemplateMethod
{
    public class HyderabadiBiriyaniStore : BiriyaniStore
    {
        public override void ConfirmOrder()
        {
            StepsPerformed.Add("Confirm: Confirmed by Hyderabadi House.");
        }

        public override void CookBiriyani()
        {
            StepsPerformed.Add("Cook: Cooked Aroma Hyderabadi dum biriyani.");
        }

        public override void PackBiriyani()
        {
            StepsPerformed.Add("Pack: Packed with Raita and Salad.");
        }
    }
}
