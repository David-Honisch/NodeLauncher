<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
<xsl:output method="xml" />
<xsl:template match="/">
<html>
	<head>
		<title>
			<xsl:copy-of select="/html/body/h1" />
		</title>
	</head>
	<body>
		<div>			
			<xsl:copy-of select="/html/head/title" />			
			<h1>
				<xsl:value-of select="/html/body/h1" />
			</h1>
			<hr />
			<xsl:copy-of select="/html/body/div" />

			<textarea>
				<xsl:copy-of select="/html/body/sql" />
			</textarea>
		</div>
	</body>
</html>
</xsl:template>
</xsl:stylesheet>



