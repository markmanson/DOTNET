<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exercise03.aspx.cs" Inherits="Day_3_4.Exercise03" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Exercise03 WebPage</title>
     <link rel="stylesheet" type="text/css" href="PageStyle.css"/>
    <script type="text/javascript" language="javascript" >
       function fnLoad()
        {
            document.getElementById('txtTextBox1').focus();

        }
        </script>
</head>
<body onload="fnLoad();">
    <form id="form1" runat="server" >
    <div>
     <table align="center">
     <tr><td>

        <asp:TextBox ID="txtTextBox1" runat="server" Height="33px"></asp:TextBox>
 
    </td><td>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="CreateDropdown" Width="125px" OnClientClick="count();" Height="39px" /><br /> <br />
         </td>  </tr> </table>
    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
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
