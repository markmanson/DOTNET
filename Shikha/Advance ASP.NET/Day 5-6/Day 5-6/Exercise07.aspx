<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exercise07.aspx.cs" Inherits="Day_5_6.Exercise07" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>EmpCache WebPage</title>
     <style type="text/css">
        .style1
        {
            height: 41px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table align="center" 
            
            style= "border-style: solid; border-color: #000080; background-color: #008080; width: 333px;" 
            #008080"><tr>
           <td class="style1">
     <asp:DropDownList ID="ddlListEmp" runat="server" Visible="false" Height="36px" Width="100px">
        </asp:DropDownList> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
       <asp:Button ID="btnCache" runat="server" Text="Cache DropdownList" 
             Style="height: 26px" Width="132px" onclick="btnCache_Click"  /></td></tr>
        </table>     
             
    </div>
    </form>
</body>
</html>
