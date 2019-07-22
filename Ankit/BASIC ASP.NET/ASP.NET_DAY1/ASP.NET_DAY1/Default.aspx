<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP.NET_DAY1._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Total Visitor</title>
</head>
<body>
    <form id="form1" runat="server" >
    <div>
        <asp:Label ID="lblPls" runat="server" Visible="false"></asp:Label>
    </div>
   
   <script language="javascript" type ="text/javascript">
    
    function Valid()
    {
    var txt=document.getElementById("txtName")
        if(txt.value.length<1)
        {
              alert("Please enter some value in textbox");
        }
    }
        
    </script>
         
    <asp:Table ID="Table1" runat="server" HorizontalAlign="Center" 
        BorderWidth="1px" style="margin-top: 0px" >
        <asp:TableRow runat="server">
        <asp:TableCell ID="TableCell1" runat="server">
        <asp:Label ID="lblName" Text="Name" runat="server"></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox> 
                                                 
        </asp:TableCell>
        <asp:TableCell ID="TableCell2" runat="server">
        <asp:Label ID="lblSession" Text="Session" runat="server"></asp:Label>
        <asp:TextBox ID="txtSession" runat="server" ReadOnly="true"></asp:TextBox>
        </asp:TableCell>
        </asp:TableRow>
        
        
        <asp:TableRow runat="server">
         <asp:TableCell ID="TableCell3" runat="server">
        <asp:Button ID="btnSubmit" Text="Submit" runat="server" 
        onclick="btnSubmit_Click" OnClientClick="Valid()" />
         </asp:TableCell>
         <asp:TableCell ID="TableCell4" runat="server">
         <asp:Label ID="lblClick" runat="server"></asp:Label>
         <asp:Label ID="lblVisitor" runat="server"></asp:Label>
         </asp:TableCell>   
         </asp:TableRow>         
    </asp:Table> 

    </form>
</body>
</html>
