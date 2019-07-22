        <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ADV_ASP_Day4.Default" %>

<%@ Register Assembly="ServerControl2" Namespace="ServerControl2" TagPrefix="CC" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Default</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="LblHeader" runat="server" Font-Size="Large"
            Text="This is Text From Some Great Article." style="font-weight: 700"></asp:Label><br /><br />
        <asp:Label ID="LblClick" runat="server" Visible="false" ForeColor="Green"></asp:Label><br /><br />
        <asp:Label ID="LblChange" runat="server" ForeColor="Green"></asp:Label><br /><br />
        <table border="2">
        <tr>
        <td><CC:RenderControl ID="RenderControl1" runat="server" OnSubmit="Submit_Click" OnCheckedChanged="Checked_Change">
        </CC:RenderControl></td>
        </tr>
        </table>        
    </div>
    </form>
</body>
</html>
