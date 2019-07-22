<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Department.aspx.cs" Inherits="Day_1_2.Department" %>
<%@ Register TagPrefix="UC" Src="~/WebUserCntrlTable.ascx" TagName="WebUserCntrlTable" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Department WebPage</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Button ID="btnGetDepart" runat="server" Text="Show Department Detail" 
            onclick="btnGetDepart_Click" Width="176px" />
           <br />
        <br />
           <br />
    </div>
     <UC:WebUserCntrlTable runat="server" ID="ucControl" Visible="false"/>
    </form>
</body>
</html>
