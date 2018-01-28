<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
	version="1.0">
	<xsl:output method="html" />
	<xsl:template match="/">
		<html>
			<head>
				<title>
					<xsl:copy-of select="/html/body/input/title" />
				</title>
			</head>
			<body>
				<h5><xsl:copy-of select="error" /></h5>
				<h1><xsl:value-of select="/html/body/config/title" /></h1>
				<h6><xsl:value-of select="/html/body/config/version" /></h6>
				<h1>
					<xsl:value-of select="/html/body/title" />
				</h1>
				<xsl:copy-of select="document('menu.xml')" />
<!-- 				Date: -->
<!-- 				<xsl:copy-of select="/html/body/date" /> -->
<!-- 				<h4>Config:</h4> -->
<!-- 				<p> -->
<!-- 					<xsl:copy-of select="/html/body/html" /> -->
<!-- 				</p> -->
				
<!-- 				<xsl:copy-of select="/html/body/input" /> -->
				
<!-- 				<p> -->
<!-- 					<xsl:copy-of select="/html/body/xslin" /> -->
<!-- 				</p> -->
<!-- 				<p> -->
<!-- 					<xsl:copy-of select="/html/body/xsl" /> -->
<!-- 				</p> -->
				<h4>Plugin Config:</h4>
				<p>
					<xsl:copy-of select="/html/body/cfgPlugin" />
				</p>
				<h4>cfgName Config:</h4>
				<p>
					<xsl:copy-of select="/html/body/cfgName" />
				</p>

<!-- 				<h5> -->
<!-- 					Route: -->
<!-- 					<xsl:copy-of select="/html/body/route" /> -->
<!-- 				</h5> -->
<!-- 				<xsl:copy-of select="/html/body/div" /> -->
<!-- 				<hr /> -->


<!-- 				<hr /> -->
<!-- 				<xsl:copy-of select="/html/body/content" /> -->
<!-- 				<hr /> -->
<!-- 				<xsl:copy-of select="/html/body/config" /> -->
<!-- 				<xsl:copy-of select="/html/body/plugin/plugins" /> -->

				<textarea width="100%" rows="10" cols="50">
					<xsl:copy-of select="/html/body/plugin/plugins" />
				</textarea>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>


