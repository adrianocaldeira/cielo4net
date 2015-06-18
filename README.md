## Cielo4Net

Biblioteca de integração com a solução WebService da Cielo em .Net.

A solução WebService da Cielo é uma solução que possibilita a integração do lojista com a estrutura de pagamento da Cielo. O objetivo da biblioteca é facilitar essa integração.

Documentação da solução WebService da Cielo está disponível em <a href="https://www.cielo.com.br/wps/wcm/connect/9c206234-75f4-45cd-a66c-2e5d368941e2/Manual_Desenvolvedor_WebService_254_v2.pdf?MOD=AJPERES&CONVERT_TO=url&CACHEID=9c206234-75f4-45cd-a66c-2e5d368941e2" target="_blank">Manual Desenvolvedor WebService</a>.

Documentação das classes da Cielo4Net está disponível em em <a href="http://cielo4net.acaldeira.me/" target="_blank">http://cielo4net.acaldeira.me/</a>.

Atualmente a biblioteca <a href="https://github.com/adrianocaldeira/cielo-4-net">Cielo4Net</a> está em acordo com a versão 2.5.4 do <a href="https://www.cielo.com.br/wps/wcm/connect/9c206234-75f4-45cd-a66c-2e5d368941e2/Manual_Desenvolvedor_WebService_254_v2.pdf?MOD=AJPERES&CONVERT_TO=url&CACHEID=9c206234-75f4-45cd-a66c-2e5d368941e2" target="_blank">Manual Desenvolvedor WebService</a> da Cielo.

## <a name="instacao"></a>Instalação

Para instalar, execute o seguinte comando no <a href="http://docs.nuget.org/docs/start-here/using-the-package-manager-console#Installing_a_Package" target="_blank">Package Manager Console</a>.

<img src="https://raw.githubusercontent.com/adrianocaldeira/cielo-4-net/master/nuget.png"/>

##<a name="release-notes"></a>Release Notes

- Versão 1.0.0
	- Primeira versão lançada no NuGet.
	
- Versão 1.0.1
	- Implementação de log de comunicação.	
	- Publicação de versão no NuGet

- Versão 1.0.2
	- Inclusão da propriedade Token (informações do cartão) na classe TransactionResult. 	

- Versão 1.0.3
	- Inclusão das propriedades contendo o Xml enviado a Cielo e o Xml que foi recebido da Cielo. 		
	
- Versão 1.0.4
	- Implementação de Timeout de requisição. 			