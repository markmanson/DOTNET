<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DrpDwn.aspx.cs" Inherits="Day_3_4.DrpDwn" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">



<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>DropDownList</title>
</head>
<body>
<script type="text/javascript">
function IfEmpty()
{
    var Item=document.getElementById("txtItem");
    if(Item.value.length<1)
    {
        alert("Please enter some values into textbox");
    }
}

</script>
    <form id="form1" runat="server">
    <div>   
        <asp:Table ID="tblTable" runat="server" HorizontalAlign="Center">
        <asp:TableRow runat="server">
        <asp:TableCell>
            <asp:TextBox ID="txtItem" runat="server" Width="302px"  ></asp:TextBox> 
        </asp:TableCell>
        
        <asp:TableCell>
            <asp:Button ID="btnAdd"
            runat="server" Text="Create DropDown" onclick="btnAdd_Click" OnClientClick="IfEmpty()" />
        </asp:TableCell>
        </asp:TableRow>
        </asp:Table>
    </div>
      <asp:PlaceHolder EnableViewState="True" ID="PlaceHolder" runat="server" Visible="True">
      </asp:PlaceHolder>  
    </form>
</body>
</html>
