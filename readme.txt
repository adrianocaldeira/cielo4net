###################################################################
Biblioteca de integração com a solução WebService da Cielo em .Net.
###################################################################

===================================================================
Configuração
===================================================================

Após a instalação é necessário configurar o arquivo(app.config ou web.config) de configuração da sua aplicação com os dados de filiação, chave de acesso e ambiente da Cielo, conforme exemplo abaixo:

<configSections>
	<section name="cielo" type="Cielo4Net.ConfigurationSection, Cielo4Net" />
</configSections>

<!--AMBIENTE DE TESTE DA CIELO-->
<cielo number="NÚMERO FILIAÇÃO CIELO" key="CHAVE DE ACESSO AO WEBSERVICE DA CIELO" environment="test"/>

<!--AMBIENTE DE PRODUÇÃO DA CIELO-->
<cielo number="NÚMERO FILIAÇÃO CIELO" key="CHAVE DE ACESSO AO WEBSERVICE DA CIELO" environment="production"/>

===================================================================
Logs de Comunicação
===================================================================

Para visualizar o processo de comunicação de envio e retorno no Output do Visual Studio é necessário efetuar a configuração abaixo:

<configSections>
	<section name="log4net" type="log4net.Config.Log4NetConfigurationSectionHandler,log4net" />
</configSections>

<log4net>
	<appender name="Trace" type="log4net.Appender.TraceAppender">
		<layout type="log4net.Layout.PatternLayout">
			<conversionPattern value="%-5level %logger - %message %newline" />
		</layout>
	</appender>
	<logger name="Cielo4Net">
		<level value="DEBUG" />
		<appender-ref ref="Trace" />
	</logger>
</log4net>
