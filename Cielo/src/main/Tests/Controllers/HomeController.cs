using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Serialization;
using Cielo;

namespace Tests.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var environment = Cielo.Configuration.Environment;
            var url = Cielo.Configuration.Url;
            var key = Cielo.Configuration.Key;
            var number = Cielo.Configuration.Number;
            var ret = "";

            var transacao = new TransactionRequest
            {
                Id = Guid.NewGuid().ToString("N"),
                Authentication = new Authentication
                {
                    Key = "Chave1",
                    Number = "Numero1"
                },
                PaymentMethod = new PaymentMethod
                {
                    Brand = PaymentMethodBrand.Aura,
                    Parcel = 5,
                    Product = PaymentMethodProduct.CreditOneParcel
                },
                AuthorizationType = TransactionRequestAuthorization.AuthorizeWithoutGoingThroughAuthentication,
                Bin = 12345,
                Capture = true,
                Card = new Card
                {
                    Expiration = 111,
                    Name = "aaa",
                    Number = 123123123,
                    SecurityCode = 123,
                    SecurityCodeStatus = CardSecurityCodeStatus.Provided
                },
                ReturnUrl = "asdasdasd",
                Order = new Order("asdasdasd", 100m, "aasasas")
            };

            var t = transacao.ToXmlString();
            try
            {
                var xmlSerializer = new XmlSerializer(typeof(TransactionRequest));
                var ms = new MemoryStream();
                var encoding = Encoding.GetEncoding("iso-8859-1");
                var xmlTextWriter = new XmlTextWriter(ms, encoding);

                xmlSerializer.Serialize(xmlTextWriter, transacao);

                ms.Close();
                xmlTextWriter.Close();

                var content = encoding.GetString(ms.ToArray());
                return Content(content);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}