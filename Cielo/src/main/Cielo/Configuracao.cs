using System.Configuration;

namespace Cielo
{
    /// <summary>
    /// Configuração Cielo
    /// </summary>
    public static class Configuracao
    {
        static Configuracao()
        {
            var configurationSection = (ConfigurationSection)ConfigurationManager.GetSection("cielo");

            Number = configurationSection.Number;
            Key = configurationSection.Key;
            Environment = configurationSection.Environment;
            
            if(Environment.ToLower().Equals("test"))
                Url = "https://qasecommerce.cielo.com.br/servicos/ecommwsec.do";

            if (Environment.ToLower().Equals("production"))
                Url = "https://ecommerce.cbmp.com.br/servicos/ecommwsec.do";
        }

        /// <summary>
        /// Recupera ou define Número de afiliação da loja com a Cielo
        /// </summary>
        public static string Number { get; private set; }
        /// <summary>
        /// Recupera Chave de acesso da loja atribuída pela Cielo
        /// </summary>
        public static string Key { get; private set; }
        /// <summary>
        /// Recupera tipo de ambiente(test ou production)
        /// </summary>
        public static string Environment { get; private set; }
        /// <summary>
        /// Recupera url do webservice da Cielo
        /// </summary>
        public static string Url { get; private set; }
    }
}