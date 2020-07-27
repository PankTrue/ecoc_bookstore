<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0"
   xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="/">
    <html>
      <body>
        <h2>Bookstore</h2>
        <table border="2">
          <tr bgcolor="#7CB07C">
            <th>Книга</th>
            <th>Автор</th>
            <th>Категория</th>
            <th>Цена</th>
            <th>Год</th>
          </tr>
          <xsl:for-each select="bookstore/book">
            <tr>
              <td>
                <xsl:value-of select="title"/>
              </td>
              <td>
                <xsl:for-each select="author">
                  <xsl:value-of select="text()"/>;
                </xsl:for-each>
              </td>
              <td>
                <xsl:value-of select="@category"/>
              </td>
              <td>
                <xsl:value-of select="price"/>
              </td>
              <td>
                <xsl:value-of select="year"/>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>

</xsl:stylesheet>
