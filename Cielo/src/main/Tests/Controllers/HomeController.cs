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
            var result = client1.CreateTransaction(new Order("98451464", 1.00M, "produto"), PaymentMethodBrand.Visa, "http://localhost:7097/Home/Result");

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
                var clientResult = client1.GetTransaction(result);
            }

            return View();
        }
    }
}