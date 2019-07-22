<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Day_6._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Choice</title>
</head>
<body>
<script type="text/javascript">
    function Chck()
    {     
        var j =0;
        var chkListModules= document.getElementById ('<%= chklstChoice.ClientID%>');
        var chkListinputs = chkListModules.getElementsByTagName("input");
        for (var i=0;i<chkListinputs .length;i++)
        {
            if (chkListinputs [i].checked)
            {
                j++;
            }
        }
        if(j<1)
        {
            alert("Please Select Atleast one CheckBox");
            return false;
        }
    }
</script>
    <form id="form1" runat="server">
    <div>
    <asp:Table ID="tblChoice" runat="server" BackColor="BlanchedAlmond" HorizontalAlign="Center" BorderColor="Black">
    <asp:TableHeaderRow runat="server">
    <asp:TableCell ColumnSpan="2">
            <asp:Label ID="lblHeader" Text="Select Multiple Options" runat="server"></asp:Label>
    </asp:TableCell>
    </asp:TableHeaderRow>
    
    <asp:TableRow runat="server">
    <asp:TableCell>
            <asp:CheckBoxList ID="chklstChoice" runat="server"   >
                    <asp:ListItem  Value="http://msdn.microsoft.com/en-us/vstudio/aa496123" Text=".NET FRAMEWORK"></asp:ListItem>
                    <asp:ListItem  Value="http://www.asp.net/" Text="ASP.NET"></asp:ListItem>
                    <asp:ListItem  Value="http://www.codeproject.com/KB/vb/"  Text="VB.NET"></asp:ListItem>
                    <asp:ListItem  Value="http://msdn.microsoft.com/en-us/library/aa288436%28v=vs.71%29.aspx" Text="C SHARP.NET"></asp:ListItem>
                    <asp:ListItem  Value="http://www.tizag.com/ajaxTutorial/" Text="AJAX"></asp:ListItem>
            </asp:CheckBoxList>
    </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
            <asp:TableCell HorizontalAlign="Center">
                    <asp:Button ID="btnSubmit" Text="Submit" runat="server" OnClientClick="Chck()" onclick="btnSubmit_Click" />
            </asp:TableCell>
    </asp:TableRow>
    </asp:Table>                    
    </div>
    </form>
</body>
</html>
