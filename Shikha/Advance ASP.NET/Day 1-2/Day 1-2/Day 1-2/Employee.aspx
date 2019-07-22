<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="Day_1_2.Employee" %>
<%@ Register TagPrefix="UC" Src="~/WebUserCntrlTable.ascx" TagName="WebUserCntrlTable" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Employee WebPage</title>
    <style type="text/css">
        .style1
        {
            width: 75px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
     <asp:Button ID="btnShwEmp" runat="server" Text="ShowEmp" 
         onclick="btnShwEmp_Click" Width="176px" />
     <br />
     <br />
    <div>
     <UC:WebUserCntrlTable runat="server" ID="ucControl" Visible="false"/>
    </div>
   
    </form>
</body>
</html>
