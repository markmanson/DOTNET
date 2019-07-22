<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:output method="xml" indent="yes"/>
 <xsl:template match="MenuItems/*">
    <!--<xsl:copy>
            <xsl:apply-templates select="@* | node()"/>
        </xsl:copy>-->
    <xsl:variable name="NodeName" >
      <xsl:value-of select="name(current())"/>
    </xsl:variable>
    <html>
      <head>
        <script lang="javascript" type="text/javascript" >
          function HideShowDiv(divid)
          {
          var divlayer = document.getElementById(divid);
          if(divlayer.style.display == "block")
          {
          divlayer.style.display = "none";

          }
          else
          divlayer.style.display = "block"
          }
          function ChangeBg(tdid)
          {
          var td = document.getElementById(tdid);
          td.style.background = "Aqua";
          td.style.color= "White";
          }
          function ReturnBg(tdid)
          {
          var td = document.getElementById(tdid);
          td.style.background = "Gray";
          td.style.color = "black";
          }
        </script>
      </head>
      <body>
        <table  border="1" width="150px">
          <tr>
            <td onmousedown="HideShowDiv('{$NodeName}')" align="Center">
              <xsl:value-of select="$NodeName"/>
             
        <!--<menu onmousedown="HideShowDiv('{$NodeName}')" align="Center" style="z-index:1 ; y-index:650px; x-index:0; Direction:Horizontal" > 
        </menu>--> 
            </td>
          </tr>
        </table>
        <div style="OVERFLOW:AUTO; width=150px; height=100px; display:none" runat="server" id="{$NodeName}" >
          <xsl:for-each select="node()">
            <table>
              <xsl:variable name="ChildNodeName">
                <xsl:value-of select="./child::node()"/>
              </xsl:variable>
              <td onmouseover="ChangeBg('{$ChildNodeName}')"
               id="{$ChildNodeName}" onmouseleave="ReturnBg('{$ChildNodeName}')"
               width="150px" align="center">
                <a>
                  <xsl:attribute name="href">
                    <xsl:value-of select="url"/>
                  </xsl:attribute>
                  <xsl:value-of select="$ChildNodeName"/>
                </a>
              </td>
            </table>
          </xsl:for-each>
        </div>
     </body>
    </html>
  </xsl:template>
</xsl:stylesheet>




