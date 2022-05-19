<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="StripePaymentCheckout.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <button type="submit">Checkout</button>

    </form>
    <script src="https://js.stripe.com/v3/"></script>
    <script>
        // Stripe Publishable Key  
        var stripe = Stripe('pk_test_51KxsOcSCpeElc4NAgMwjZGuNcKM3r3oS5kQBX8B31IwfjmoVSgKwxVdDWwET0LQHGzgt6OzqZvwtjVFSWCnEN8eU00njbgTyLz');
        var form = document.getElementById("form1");

        // Onclick 
        form.addEventListener('submit', function (e) {
            e.preventDefault();
            // Redirects to Stripe Checkout Sessioon
            stripe.redirectToCheckout({
                sessionId: "<%= sessionId %>"
            });
        });
    </script>
</body>
</html>
