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
            var environment = Cielo.Configuracao.Environment;
            var url = Cielo.Configuracao.Url;
            var key = Cielo.Configuracao.Key;
            var number = Cielo.Configuracao.Number;
            var ret = "";
            try
            {
                var xs = new XmlSerializer(typeof(Transaction));
                var ms = new MemoryStream();
                var encoding = Encoding.GetEncoding("iso-8859-1");
                var xw = new XmlTextWriter(ms, encoding);

                var transacao = new Transaction();

                transacao.Autenticacao = new Authentication
                {
                    Key = "Chave1",
                    Number = "Numero1"
                };
                transacao.Pagamento = new Pagamento
                {
                    Bandeira = PagamentoBandeira.Aura,
                    Parcelas = 5,
                    Produto = PagamentoProduto.ParceladoLoja 
                };
                xs.Serialize(xw, transacao);

                ms.Close();
                xw.Close();

                ret = encoding.GetString(ms.ToArray());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            
            return View();
        }
    }
}