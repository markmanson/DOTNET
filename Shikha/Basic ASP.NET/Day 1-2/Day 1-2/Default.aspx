<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Day_1_2._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Counter WebPage</title>
    <link rel="stylesheet" type="text/css" href="PageStyle.css">
   
</head>
<body>
    <form id="form1" runat="server">
    <div>
   
   
    <table align="center" >
        <tr>
            <td class="style2">
                </td>
            <td class="style14">
                Name</td>
            <td class="style4">
                <asp:TextBox ID="txtTextBox1" runat="server"></asp:TextBox>
            </td>
            <td class="style6">
Session Value</td>
            <td class="style7">
                <asp:TextBox ID="txtTextBox2" runat="server" ReadOnly="true"></asp:TextBox>
            </td>
            <td class="style5">
                </td>
        </tr>
        <tr>
            <td class="style8">
            </td>
            <td class="style15">
            </td>
            <td class="style10" colspan="2">
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 
                  <asp:Button  ID="btnSubmit" runat="server" style="margin-left: 0px" Text="Submit" 
                    Width="103px" Height="38px" onclick="btnSubmit_Click" OnClientClick="count();">
                    </asp:Button>
            </td>
            <td class="style12">
            </td>
            <td class="style13">
            </td>
        </tr>
        <tr>
            <td class="style16">
                </td>
            <td class="style17">
                </td>
            <td class="style18">
                <asp:Label ID="LblCounter" runat="server" >Num of OnlineUser</asp:Label>
            </td>
            <td class="style19">
                </td>
            <td class="style20">
                <asp:Label ID="LblCounter1" runat="server" >Num of CurrentUser</asp:Label>
            </td>
            <td class="style21">
                </td>
        </tr>
        </table>
         <script type="text/javascript" language="javascript">
         
function count()
{
var C =document.getElementById("txtTextBox1");
if (C.value=="")
{
alert(" please enter value in textbox");

}
}

</script>
         </div>
    </form>
</body>
</html>
