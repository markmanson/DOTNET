<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exercise2.aspx.cs" Inherits="Day8_9.Exercise2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Table ID="Table1" runat="server" HorizontalAlign="Center" BorderColor="Black" BorderWidth="2" BackColor="Honeydew" Width="500px">
        <asp:TableRow><asp:TableCell HorizontalAlign="Right" ColumnSpan="2">
                    <asp:Button ID="btnLang" runat="server" Text="English" onclick="btnLang_Click" CausesValidation="false" />    
    </asp:TableCell></asp:TableRow>
    <asp:TableHeaderRow ><asp:TableHeaderCell HorizontalAlign="Center" ColumnSpan="2">
        <asp:Label ID="lblHeader" Text="Login" runat="server" Font-Bold="true" Font-Size="Larger"></asp:Label>
    </asp:TableHeaderCell></asp:TableHeaderRow>
    <asp:TableRow><asp:TableCell>
        <asp:Label ID="lblUser" runat="server"  Width="250px" Text="UserID" ></asp:Label>
    </asp:TableCell>
    <asp:TableCell>
    <asp:TextBox ID="txtUser" runat="server" Width="250px"></asp:TextBox>
       <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Text="*" SetFocusOnError="true" ControlToValidate="txtUser" ErrorMessage="You must enter User ID" Display="None"></asp:RequiredFieldValidator>
   </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow><asp:TableCell>
        <asp:Label ID="lblPass" runat="server" Text="Password" Width="250px"></asp:Label>
    </asp:TableCell><asp:TableCell>
        <asp:TextBox ID="txtPass" runat="server" Width="250px" TextMode="Password"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Text="*" SetFocusOnError="true" ControlToValidate="txtPass" ErrorMessage="You must enter Password" Display="None"></asp:RequiredFieldValidator>
   </asp:TableCell></asp:TableRow>
    <asp:TableRow><asp:TableCell>    
                        <asp:Button ID="btnSignIn" Text="SignOn" runat="server"  Width="250px" onclick="btnSignIn_Click"  />        
    </asp:TableCell><asp:TableCell>
                <asp:Button ID="btnCancel" Text="Cancel" runat="server" Width="250px" CausesValidation="false" onclick="btnCancel_Click" />   
    </asp:TableCell></asp:TableRow>
    <asp:TableRow><asp:TableCell HorizontalAlign ="Center" ColumnSpan="2">
        <asp:Label ID="lblError" runat="server" Visible="false" ForeColor="Red"></asp:Label>
    </asp:TableCell></asp:TableRow>
    <asp:TableRow><asp:TableCell HorizontalAlign ="Center" ColumnSpan="2">
    <asp:ValidationSummary ID="ValidationSummary1"
    HeaderText="Please fix the following errors..."
    DisplayMode="BulletList"
    EnableClientScript="true" 
    runat="server"/>
    </asp:TableCell></asp:TableRow>
    </asp:Table>  
    </div>
    </form>
</body>
</html>
