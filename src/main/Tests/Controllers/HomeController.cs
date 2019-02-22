using System;
using System.Net;
using System.Web.Mvc;
using Cielo4Net;

namespace Tests.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            Cielo = new Communication();
        }
        
        public Communication Cielo { get; set; }

        // GET: Home
        public ActionResult Index()
        {
            var transaction = new Transaction
            {
                Order = new Order("456878", 1.00M, "produto"),
                PaymentMethod = new PaymentMethod
                {
                    Brand = PaymentMethodBrand.Visa,
                    Parcel = 1,
                    Product = PaymentMethodProduct.CreditOneParcel
                },
                ReturnUrl = "http://localhost:7097/Home/Result",
                AuthorizationType = TransactionAuthorizationType.AllowAuthenticatedAndUnauthenticated
            };

            var result = Cielo.CreateTransaction(transaction);

            if (result.IsError)
            {
                return Content(result.Error.Message);
            }

            Session["Transaction"] = result.Transaction;

            return Redirect(result.Transaction.UrlAuthentication);
        }

        public ActionResult Result()
        {
            var transactionResult = Session["Transaction"] as TransactionResult;

            if (transactionResult != null)
            {
                var communicationResult = Cielo.GetTransaction(transactionResult.Tid);

                if (communicationResult.IsError)
                {
                    return Content("Erro:<br><br>" + communicationResult.Error.Message);
                }

                return Content(communicationResult.Transaction.Status.ToString());
            }

            return Content("Sem resultado de transação");
        }
    }
}