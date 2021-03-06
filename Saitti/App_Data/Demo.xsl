<?xml version="1.0"?>
<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
      <h2>Akun Tehdas Työntekijät</h2>
        <table border="1">
          <tr bgcolor="#9acd32">
            <th>Etunimi</th>
            <th>Sukunimi</th>
            <th>Numero</th>
            <th>tyosuhde</th>
            <th>palkka</th>
          </tr>
          <xsl:for-each select="tyontekijat/tyontekija">
            <tr>
              <!--<xsl:if test="tyosuhde='vakituinen'">-->
                <td><xsl:value-of select="etunimi"/></td>
                <td><xsl:value-of select="sukunimi"/></td>
                <td><xsl:value-of select="numero"/></td>
                <td><xsl:value-of select="tyosuhde" /></td>
                <td><xsl:value-of select="palkka"/></td>
             <!-- </xsl:if>-->
            </tr>
          </xsl:for-each>
        </table>
    <xsl:if test="tyontekijat/tyontekija/tyosuhde='vakituinen'">
      <xsl:value-of select="count(/tyontekijat/tyontekija/tyosuhde"/>
    </xsl:if>
  </xsl:template>
</xsl:stylesheet>
