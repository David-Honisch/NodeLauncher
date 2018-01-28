<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
	version="1.0">
	<xsl:output method="html" />
	<xsl:template match="/">
		<html>
			<head>
				<title>
					<xsl:copy-of select="/html/body/title" />
				</title>
			</head>
			<body>
				<h6>Version v.1.0</h6>
				<h1>
					<xsl:value-of select="/html/body/title" />
				</h1>
				<xsl:copy-of select="document('menu.xml')" />
				CFGHTML:<xsl:copy-of select="/html/body/cfghtml" />
				Date:<xsl:copy-of select="/html/body/date" />
				<h4>Config:</h4>
				<p><xsl:copy-of select="/html/body/cfg" /></p>
				<h4>Plugin Config:</h4>
				<p><xsl:copy-of select="/html/body/cfgPlugin" /></p>
				<h4>cfgName Config:</h4>
				<p><xsl:copy-of select="/html/body/cfgName" /></p>
				
				<h5>Route:<xsl:copy-of select="/html/body/route" /></h5>
				<xsl:copy-of select="/html/body/div" />
				<hr />
				<xsl:copy-of select="/html/body/content" />
				<hr />
				<xsl:copy-of select="/html/body/config" />
<!-- 				<xsl:copy-of select="/html/body/plugin/plugins" /> -->

				<textarea width="100%" rows="10" cols="50">
					<xsl:copy-of select="/html/body/plugin/plugins" />
				</textarea>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>


