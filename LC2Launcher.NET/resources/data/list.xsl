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
			<xsl:copy-of select="document('menu.xml')" />
				<h1>
					<xsl:value-of select="/html/body/title" />
				</h1>
				<h2>ConfigFile:</h2>
				<xsl:copy-of select="/html/body/config/cfg" />
				<hr />
				<h2>Database Index:</h2>
				<xsl:copy>
					<xsl:for-each select="/html/body/sql/ul/li">					
					
					<xsl:variable name="NAME"><xsl:copy-of select="text()" /></xsl:variable>
					<a href="{$NAME}"><xsl:value-of select="$NAME"/></a><br/>
<!-- 					<a href="{$NAME}"><xsl:value-of select="replace($NAME, '&amp;', '&;')"/></a><br/> -->
					
					</xsl:for-each>
				</xsl:copy>
<!-- 				<hr /> -->
<!-- 				/html/body/sql/ul/li -->
<!-- 				<xsl:copy-of select="/html/body/sql" /> -->
				<hr />
				<form action="lc:list;list">
				<input type="text" name="lc:" value="index"></input>
				<input type="submit" name="submit" value="Submit"></input>
				</form>
				<!-- <xsl:copy-of select="/html/body" /> -->
				<!-- <textarea> -->
				<!-- <xsl:copy-of select="/html/body" /> -->
				<!-- </textarea> -->
				<!-- <hr /> -->

				<hr />
				<a href="lc:imprint;imprint">Imprint</a>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>


