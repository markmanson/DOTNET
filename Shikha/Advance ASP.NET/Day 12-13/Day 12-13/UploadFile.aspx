<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadFile.aspx.cs" Inherits="Day_12_13.UploadFile" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>UploadFile WebPage</title>
</head>
<body>
    <form id="form1" runat="server" 
    style="background-color: #FFCCCC; border-style: solid; border-color: #800000">
    <div>
        <asp:FileUpload ID="FileUpOfEmp" runat="server" Height="39px" Width="242px" />
        <br />
        <br />
    </div>
    <div style="height: 220px">
        <asp:Button ID="btnUpload" runat="server" Text="Upload" Height="41px" 
            onclick="btnUpload_Click" Width="118px" BackColor="#FF6699" 
            BorderColor="#FF0066" Font-Bold="True" Font-Italic="True" Font-Size="Large" 
            style="margin-left: 26px" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="lblMessage" runat="server" BackColor="#FF9966" Font-Bold="True" 
            Font-Italic="True" Font-Size="X-Large" ForeColor="#0000CC" Text="Label" 
            Visible="False"></asp:Label>
    </div>
    </form>
</body>
</html>
