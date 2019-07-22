<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exercise05.aspx.cs" Inherits="Day_5_6._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ OutputCache Duration="30" VaryByParam="None" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Time WebPage</title>
</head>
<body>
     <form id="Form1" method="post" runat="server" 
     style="border-style: solid; border-color: #800000; background-color: #C0C0C0">
      <h2 style="font-weight: bold; font-style: italic; color: #800080; background-color: #808080; font-size: xx-large; height: 78px; border-bottom-style: solid; border-bottom-color: #000080;">Caching Web Forms</h2>
      <p style="color: #800080; font-size: large; font-weight: bold; font-style: italic;">Click Refresh to see how server-side information is cached.</p>
      <p style="color: #008080">Time this page was cached (server-side code):
        <%  Response.Write("server time" + DateTime.Now);  %>
      </p>
      <p style="color: #800000">Current time (client-side code):
        <script type="text/javascript">document.write(Date());</script>
      </p>
    </form>

</body>
</html>
