## Cielo4Net

Biblioteca de integração com a solução WebService da Cielo em .Net.

A solução WebService da Cielo é uma solução que possibilita a integração do lojista com a estrutura de pagamento da Cielo. O objetivo da biblioteca é facilitar essa integração.

Documentação da solução WebService da Cielo está disponível em <a href="https://github.com/adrianocaldeira/cielo4net/raw/master/docs/Manual_Desenvolvedor_WebService_254_v2.pdf" target="_blank">Manual Desenvolvedor WebService</a>.

Documentação das classes da Cielo4Net está disponível em em <a href="http://cielo4net.acaldeira.me/" target="_blank">http://cielo4net.acaldeira.me/</a>.

#
## <a name="instacao"></a>Instalação

Para instalar, execute o seguinte comando no <a href="http://docs.nuget.org/docs/start-here/using-the-package-manager-console#Installing_a_Package" target="_blank">Package Manager Console</a>.

<img src="https://raw.githubusercontent.com/adrianocaldeira/cielo-4-net/master/nuget.png"/>

#
## <a name="release-notes"></a>Release Notes

- Versão 1.0.7
	- Implementação do SecurityProtocol para Tls12 e Ssl3. 	
    - Atualização do .Net Framework de 4.5 para 4.7.2.	
- Versão 1.0.6
	- Atualização de dependências.
- Versão 1.0.5
	- Tipo da propriedade SecurityCode alterada para string. 
- Versão 1.0.4
	- Implementação de Timeout de requisição. 
- Versão 1.0.3
	- Inclusão das propriedades contendo o Xml enviado a Cielo e o Xml que foi recebido da Cielo. 		
- Versão 1.0.2
	- Inclusão da propriedade Token (informações do cartão) na classe TransactionResult. 	
- Versão 1.0.1
	- Implementação de log de comunicação.	
	- Publicação de versão no NuGet
- Versão 1.0.0
	- Primeira versão lançada no NuGet.