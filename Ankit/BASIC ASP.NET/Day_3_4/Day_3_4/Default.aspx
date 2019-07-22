<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Day_3_4._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Day-3_4</title>
    <script type="text/javascript">
    function Remove()
    {
        var Item=document.getElementById("lstFrst");
        if(Item.value=="")
        {
            alert("There is no item to remove...");
        }
    }
    function NoText()
    {
        var Text=document.getElementById("txtItem").value;
        if(Text.length<1)
        {
            alert("Please enter some value into Textbox");
        }
    }
    function NoLeft()
    {
        var Item=document.getElementById("lstScnd").value;
        if(Item==0)
        {
            alert("There is no item to move");
        }
    }
     function NoRight()
    {
        var Item=document.getElementById("lstFrst").value;
        if(Item==0)
        {
            alert("There is no item to move");
        }
    }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     </div>
    <asp:Label ID="lblMsg" runat="server" Visible="false"></asp:Label>
        <asp:Table ID="Table1" runat="server" HorizontalAlign="Center"  BorderWidth="2">
        <asp:TableRow  >
        <asp:TableCell ColumnSpan=2>
                        <asp:TextBox ID="txtItem"  runat="server"></asp:TextBox>  
        </asp:TableCell>
        <asp:TableCell>
                        <asp:Button ID="btnAdd" runat="server" Text="AddItem" onclick="btnAdd_Click" OnClientClick="NoText()" />
        </asp:TableCell>
        </asp:TableRow>
        
        
        <asp:TableRow>
        <asp:TableCell RowSpan="2">
                        <asp:ListBox ID="lstFrst" runat="server" Width="120px"></asp:ListBox>
        </asp:TableCell>
        <asp:TableCell RowSpan="2">
                           <asp:Button ID="BtnLft" Text="<" runat="server" onclick="BtnLft_Click"  OnClientClick="NoLeft()" />                     
        </asp:TableCell>
       
        <asp:TableCell RowSpan="2">
                        <asp:Button ID="BtnRight" Text=">" runat="server" onclick="BtnRight_Click" OnClientClick="NoRight()" />
        </asp:TableCell>
       
        <asp:TableCell RowSpan="2">
                        <asp:ListBox ID="lstScnd" runat="server" Width="120px"></asp:ListBox>
        </asp:TableCell>
        </asp:TableRow>
        
        <asp:TableRow >
        <asp:TableCell >
                        <asp:Button ID="BtnRemove" Text="Remove" runat="server" 
        onclick="BtnRemove_Click" OnClientClick="Remove()" style="height: 26px" />
        </asp:TableCell>
        </asp:TableRow>
        </asp:Table>
   
       
    
   
    </form>
</body>
</html>
