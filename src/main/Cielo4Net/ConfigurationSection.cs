using System.Configuration;

namespace Cielo4Net
{
    /// <summary>
    ///     Seção de configuração.
    /// </summary>
    public class ConfigurationSection : System.Configuration.ConfigurationSection
    {
        /// <summary>
        ///     Recupera ou define Número de afiliação da loja com a Cielo.
        /// </summary>
        [ConfigurationProperty("number", IsRequired = true)]
        public string Number
        {
            get { return (string) base["number"]; }
            set { base["number"] = value; }
        }

        /// <summary>
        ///     Recupera ou define Chave de acesso da loja atribuída pela Cielo.
        /// </summary>
        [ConfigurationProperty("key", IsRequired = true)]
        public string Key
        {
            get { return (string) base["key"]; }
            set { base["key"] = value; }
        }

        /// <summary>
        ///     Recupera ou define ambiente.
        /// </summary>
        [ConfigurationProperty("environment", IsRequired = true)]
        public string Environment
        {
            get { return (string) base["environment"]; }
            set { base["environment"] = value; }
        }

        /// <summary>
        ///     Recupera ou define timeout.
        /// </summary>
        [ConfigurationProperty("timeout", DefaultValue = 30000)]
        public int Timeout
        {
            get { return (int)base["timeout"]; }
            set { base["timeout"] = value; }
        }
    }
}