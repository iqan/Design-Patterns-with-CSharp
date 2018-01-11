namespace _2_Behavioral.TemplateMethod
{
    public class A1BiriyaniStore : BiriyaniStore
    {
        public override void ConfirmOrder()
        {
            StepsPerformed.Add("Confirm: Confirmed by A1 Biriyani House.");
        }

        public override void CookBiriyani()
        {
            StepsPerformed.Add("Cook: Cooked A1 Special biriyani.");
        }

        public override void PackBiriyani()
        {
            StepsPerformed.Add("Pack: Packed with Chutney and Salad.");
        }
    }
}
