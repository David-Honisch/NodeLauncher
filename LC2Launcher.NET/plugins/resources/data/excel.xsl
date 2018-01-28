<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:output method="text" encoding="ISO-8859-1"/>
<xsl:template match="adressen">Name;Straße;Plz;Ort
<xsl:for-each select="adresse">
<xsl:value-of select="name"/>
<xsl:text>;</xsl:text>
<xsl:value-of select="strasse"/>
<xsl:text>;</xsl:text>
<xsl:value-of select="plz"/>
<xsl:text>;</xsl:text>
<xsl:value-of select="ort"/>
<xsl:text>
</xsl:text>
</xsl:for-each>
</xsl:template>
</xsl:stylesheet>