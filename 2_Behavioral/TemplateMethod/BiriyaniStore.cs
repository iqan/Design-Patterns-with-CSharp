using System.Collections.Generic;
using _2_Behavioral.TemplateMethod.Classes;

namespace _2_Behavioral.TemplateMethod
{
    public abstract class BiriyaniStore
    {
        private readonly IBiriyani _biriyani = new Biriyani();
        public List<string> StepsPerformed { get; set; }

        public BiriyaniStore()
        {
            StepsPerformed = new List<string>();
        }

        public IBiriyani OrderBiriyani()
        {
            PlaceOrder();
            ProcessPayment();
            ConfirmOrder();
            CookBiriyani();
            PackBiriyani();
            return _biriyani;
        }

        private void PlaceOrder()
        {
            // Send Order Request
        }

        private void ProcessPayment()
        {
            // Process Payments
        }

        public abstract void ConfirmOrder();
        public abstract void CookBiriyani();
        public abstract void PackBiriyani();
    }
}
