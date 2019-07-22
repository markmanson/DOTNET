<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Display.aspx.cs" Inherits="Day_1_2._Default" %>
<%@ Register TagPrefix="UC" Src="~/DisplayNum.ascx" TagName="DisplayNum" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Counter WebPage</title>
    <style type="text/css">
        .style2
        {
            height: 97px;
            width: 148px;
        }
        .style3
        {
            height: 79px;
            width: 258px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table align="center" style="border-color:Black; background-color:Gray" border="2"><tr>
       <td class="style3" 
            style="font-weight: bold; color: #000080; font-size: large; text-decoration: blink">Counter&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
  <asp:TextBox ID="textNumber" runat="server" 
    ReadOnly="True" Width="99px" Enabled="False" BorderColor="#990099" ForeColor="#990000" 
                Height="41px"  />
    </td></tr><tr><td class="style2">
     <UC:DisplayNum runat="server" ID="ucControl" />
   </td></tr>  </table>
    </div>
    </form>
</body>
</html>
