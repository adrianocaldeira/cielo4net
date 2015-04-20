using System;
using System.Web.Mvc;
using Cielo;

namespace Tests.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var client1 = new Client();
            var transaction = new Transaction
            {
                Id = Guid.NewGuid().ToString("N"),
                Order = new Order("456878", 1.00M, "produto"),
                PaymentMethod = new PaymentMethod
                {
                    Brand = PaymentMethodBrand.Visa,
                    Parcel = 1,
                    Product = PaymentMethodProduct.Debit
                },
                ReturnUrl = "http://localhost:7097/Home/Result",
                AuthorizationType = TransactionAuthorizationType.AllowAuthenticatedAndUnauthenticated
            };
            var result = client1.CreateTransaction(transaction);

            if (result.IsError)
            {
                return Content(result.Error.Message);
            }

            Session["Transaction"] = result.Transaction;

            return Redirect(result.Transaction.UrlAuthentication);
        }

        public ActionResult Result()
        {
            var result = Session["Transaction"] as TransactionResult;

            if (result != null)
            {
                var client1 = new Client();
                var tid = "100173489802A1651001";
                var clientResult = client1.GetTransaction(result.Tid);
                var cancelTransaction = client1.CaptureTransaction(result.Tid);
                new can
                clientResult = client1.GetTransaction(result.Tid);
            }

            return View();
        }
    }
}