<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginUser.aspx.cs" Inherits="Day_9_10.LoginUser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Login WebPage</title>
   <link rel="stylesheet" type="text/css" href="Style.css"> 
    <style type="text/css">
        #form1
        {
            height: 378px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
  
    <div style="height: 299px">
   
     <asp:Panel ID="pnlMain" runat="server" Width="620px">
     
     <asp:Table ID="Table1" runat ="server" HorizontalAlign="Center" 
             BackColor="LightCyan" BorderStyle="Inset" BorderColor="Coral" BorderWidth="2"
            Width="363px" Height="248px" style="margin-left: 17px">
        <asp:TableHeaderRow >
            <asp:TableHeaderCell HorizontalAlign="Center" ColumnSpan="2"><asp:Label ID="lblHead" runat="server" Text="Login Details"></asp:Label>
            <%--<asp:ImageButton class="ImgSubmit" 
                    imageurl="~/Image/login.png" 
                    id="ImageButton1" 
                    runat="server" 
                    Height="58px" Width="86px"/>--%>
                <asp:Image ID="Image1" ImageUrl="~/Image/login.png" Height="58px" Width="86px" runat="server" />
            </asp:TableHeaderCell>
        </asp:TableHeaderRow>
        <asp:TableRow>
            <asp:TableCell><asp:Label ID="lblName" Text="Name" runat="server"></asp:Label>
            </asp:TableCell>
            <asp:TableCell><asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFName" runat="server" Text="*" SetFocusOnError="true" ErrorMessage="Enter the Name" Display="Dynamic" ControlToValidate="txtName"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><asp:Label ID="lblPass" Text="Password" runat="server"></asp:Label>
            </asp:TableCell>
            <asp:TableCell><asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFPass" runat="server" SetFocusOnError="true" ErrorMessage="Enter The Password" Text="*" Display="Dynamic" ControlToValidate="txtPass"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan="2" HorizontalAlign="Center"><asp:Button ID="btnSubmit" runat="server" Text="Login" onclick="btnSubmit_Click" />
               
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableFooterRow>
            <asp:TableCell ColumnSpan="2" HorizontalAlign="Center"><asp:ValidationSummary ID="Val"
                    HeaderText="Please Enter details in Field..."
                    DisplayMode="BulletList"
                    EnableClientScript="true" 
                    runat="server"/>
            </asp:TableCell>
        </asp:TableFooterRow>
    </asp:Table>                
</asp:Panel>

      <%--  <ajaxToolkit:RoundedCornersExtender   
            ID="RoundedCornersExtender1"  
            runat="server"  
            TargetControlID="pnlMain"  
            Corners="All"  
            Color="#c0c0c0"  
            Radius="20">  
        </ajaxToolkit:RoundedCornersExtender>  --%>
          
    </div>
    
    </form>
     
</body>
</html>
