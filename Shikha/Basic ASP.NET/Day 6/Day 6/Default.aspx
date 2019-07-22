<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Day_6._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Choice WebPage</title>
<link rel="stylesheet" type="text/css" href="Stylesheet1.css">

    <script type="text/javascript" language="javascript">
 
function ValidateEducations() {
var chkEducations = document.getElementById('<%= cblSelect.ClientID %>');
if(chkEducations) {
var chkEducationsItemList = chkEducations.getElementsByTagName('input');
if(chkEducationsItemList) {
if(chkEducationsItemList.length > 0) {
for(var i = 0 ; i < chkEducationsItemList.length; i++) {
var chkEducationsItem = chkEducationsItemList[i];
if(chkEducationsItem) {
if(chkEducationsItem.type == 'checkbox') {
if(chkEducationsItem.checked) {
return true;

}


}
}
}
}
}
}
alert ('You didn\'t choose any of the checkboxes!');
return false;
}


    </script>

   

    <style type="text/css">
        .style1
        {
            width: 171px;
        }
        .style2
        {
            width: 183px;
        }
    </style>

   
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table class="style1" align="center" >
            <tr>
                <td class="style2">
                   Select Multiple Option
                </td>
            </tr>
            <tr>
                <td class="style2" >
                    <asp:CheckBoxList ID="cblSelect" name="chk1" runat="server" Width="125px"   >
                        
                        <asp:ListItem Text=".NetFramework" Value="http://www.w3schools.com" ></asp:ListItem>
                        <asp:ListItem Text="Asp.Net" Value="http://www.asp.net" ></asp:ListItem>
                        <asp:ListItem Text="VB.Net" Value="http://www.google.com" ></asp:ListItem>
                        <asp:ListItem Text="C Sharp.Net" Value="http://www.maths.com" ></asp:ListItem>
                        <asp:ListItem Text="Ajax" Value="http://www.sciencemag.org/" ></asp:ListItem>
                    </asp:CheckBoxList>
                   
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;
                    <asp:Button ID="Button1" runat="server" Height="40px" Text="Submit" Width="73px"
                        OnClick="Button1_Click" OnClientClick="return ValidateEducations()"/>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
