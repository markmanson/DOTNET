<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DAY5EXercise._Default" %>

<%@ OutputCache Duration="30" VaryByParam="None" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cache Page</title>
    <link href="Stylesheet.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel runat="server" GroupingText="Caching" ID="Pnl" CssClass="panel" Font-Size="12px">
            <table class="Dynamictable">
                <tr>
                    <td class="Bodytd">
                        <% Response.Write("Server-Side:" + DateTime.Now.ToString()); %>
                    </td>
                </tr>
                <tr>
                    <td class="Bodytd">
                        <script language="javascript" type="text/javascript">document.write("Client-Side:",Date());</script>
                    </td>
                </tr>
            </table>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
