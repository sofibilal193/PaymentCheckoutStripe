using Stripe;
using Stripe.Checkout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StripePaymentCheckout
{
    public partial class Index : System.Web.UI.Page
    {
        public string sessionId = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            // Create Checkout Session

            // Secret Key--Stripe
            StripeConfiguration.ApiKey = "sk_test_51KxsOcSCpeElc4NAFr9lUqswE0BtyqSwpj143KTiwBigpN0jeM2d6471JCv7yDiRAIgFx8NqCa2rObQ8wPqNOxaS00DiT1sbE7";

            var options = new SessionCreateOptions
            {
                SuccessUrl = "https://localhost:44325/success?id={CHECKOUT_SESSION_ID}",
                CancelUrl = "https://localhost:44325/cancel",
                PaymentMethodTypes = new List<string>
                {
                    "card",
                },
                LineItems = new List<SessionLineItemOptions>
              {
                new SessionLineItemOptions
                {
                 Name = "T-Shirt",
                 Description = "Cotton Made Comfortable",
                 Amount = 1000,
                 Currency = "usd",
                 Quantity = 2,
                },
              },
                Mode = "payment",
            };
            var service = new SessionService();
            Session session = service.Create(options);

            sessionId = session.Id;
        }
    }
}