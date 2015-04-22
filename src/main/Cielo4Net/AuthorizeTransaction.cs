using System;
using System.Xml.Serialization;

namespace Cielo4Net
{
    /// <summary>
    ///     Autorização de uma transação previamente gerada
    ///     Para os estabelecimentos utilizando o processo de autenticação, é possível solicitar a autorização das transações
    ///     que pararam após a execução deste processo. A mensagem para performar tal operação é a “requisicao-autorizacao-tid”
    ///     como descrita abaixo:
    ///     INFORMAÇÃO: requisições para transações que não foram submetidas ao processo de autenticação ou foram
    ///     interrompidas, pois o portador errou a senha não serão aceitas.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://ecommerce.cbmp.com.br")]
    [XmlRoot("requisicao-autorizacao-tid", Namespace = "http://ecommerce.cbmp.com.br", IsNullable = false)]
    public class AuthorizeTransaction : Request
    {
    }
}