<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="day_5._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Registration WebPage</title>
   <link rel="stylesheet" type="text/css" href="Stylesheet1.css">
  
</head>
<body onload="fnLoad();">
    <form id="form1" runat="server">
    <div>
    
        <table align="center" class="style1">
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style3">
&nbsp;Name <span style ="color:Red ">*</span></td>
                <td class="style4">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="rfvName" 
                 runat="server" 
                ControlToValidate="txtName"
               ErrorMessage="First Name can't be left blank" 
                SetFocusOnError="True" Display="None">
        </asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator ID="regexpName" runat="server"     
                                    ErrorMessage="Name expression does not validate." 
                                    ControlToValidate="txtName" SetFocusOnError="True"    
                                    ValidationExpression="^[a-zA-Z'.\s]{1,40}$" Display="None" />
                </td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style3">
                    Sex</td>
                <td class="style4">
                    <asp:TextBox ID="txtSex" runat="server"></asp:TextBox>
                     <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"     
                                    ErrorMessage="Please Enter only M/F Character " Display="None"
                                    ControlToValidate="txtSex" SetFocusOnError="True"   
                                    ValidationExpression="^[M/F]{1,1}$">
         </asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style3">
                    Email <span style ="color:Red ">*</span></td>
                <td class="style4">
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator   
             ID="rfvEmail"  
             runat="server"  
             ControlToValidate="txtEmail"  SetFocusOnError="True"
             ErrorMessage="Email cant be left blank" Display="None">
             
        </asp:RequiredFieldValidator>  
        <asp:RegularExpressionValidator   
            ID="RegularExpressionValidator2"  
            runat="server"   
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"  
            ControlToValidate="txtEmail"  SetFocusOnError="True"
            ErrorMessage="Input valid email address!"  Display="None"
            >  
        </asp:RegularExpressionValidator>  
                </td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style3">
                    DOB</td>
                <td class="style4">
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                   <%-- <asp:TextBox ID="txtCurrentdate" runat="server"></asp:TextBox>--%>
  <asp:TextBox ID="txtDob" runat="server"></asp:TextBox>
<asp:ImageButton runat="Server" ID="imgBtnCal" ImageUrl="~/Image/calendar_icon.png" 
                        AlternateText="Click here to display calendar" Height="16px" 
                        Width="28px"  />
<ajaxToolkit:CalendarExtender   runat="server" ID="CalendarExtender1" PopupButtonID="imgBtnCal" TargetControlID="txtDob"
                    Format="yyyy/MM/dd">
                </ajaxToolkit:CalendarExtender>
               <%-- <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="TO DATE cannot be Greater than FROM DATE"
     ControlToValidate="txtDob"
      ValueToCompare="dateString" Display="None"></asp:CompareValidator>--%>
            <asp:RangeValidator 
    ID="RangeValidator1"
    runat="server" 
    ControlToValidate="txtDob" 
    ErrorMessage="*Please Enter date less than current date" Display="None" SetFocusOnError="True" 
    Type="Date" > </asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style3">
                    Password <span style ="color:Red ">*</span></td>
                <td class="style4">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvPassword" 
                 runat="server" 
                ControlToValidate="txtPassword"
               ErrorMessage="Password can't be left blank" 
                SetFocusOnError="True" Display="None">
        </asp:RequiredFieldValidator>
<asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server"    
ErrorMessage="Atleast first two numeric character and minimum lenth must be 8" Display="None"
ControlToValidate="txtPassword" SetFocusOnError="True"   
ValidationExpression="^(?=.*\d){2,}(?=.*[a-zA-Z]).{6,}$">
</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style3">
                    FaxNumber</td>
                <td class="style4">
                    <asp:TextBox ID="txtFaxNumber" runat="server"></asp:TextBox>
                      <asp:RegularExpressionValidator   
            ID="RegularExpressionValidator5"  
            runat="server"   
            ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"  
            ControlToValidate="txtFaxNumber"  Display="None" SetFocusOnError="True"
            ErrorMessage="Input valid Fax number Number!(###)###-####"  
            ></asp:RegularExpressionValidator> 
                </td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style3">
                    Married</td>
                <td class="style4">
                    <asp:DropDownList ID="ddlMarried" runat="server" Width="121px">
                    <asp:ListItem Text="--Select--" Value=" " Selected="true"></asp:ListItem>
                    <asp:ListItem Text="Yes" Value="Yes" Selected="False"></asp:ListItem>
<asp:ListItem Text="No" Value="No" Selected="False"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style3">
                    Language Known <span style ="color:Red ">*</span></td>
                <td class="style4">
                    <asp:ListBox ID="lstLanguage" runat="server" SelectionMode="Multiple" 
                        Width="105px">
                         <asp:ListItem Text="Hindi" Value="Hindi" />
    <asp:ListItem Text="English" Value="English" />
    <asp:ListItem Text="Japanies" Value="Japanies" />
    <asp:ListItem Text="Spanish" Value="Spanish" />
     <asp:ListItem Text="Other" Value="Other" />
                        </asp:ListBox>
                 <asp:CustomValidator ID="CustomValidator1"  runat="server" ErrorMessage="At least one item selected from listbox"
ClientValidationFunction = "ValidateListBox" Display="None" SetFocusOnError="True"></asp:CustomValidator>
<script type = "text/javascript">
function ValidateListBox(sender, args) {
    var options = document.getElementById("<%=lstLanguage.ClientID%>").options;
    for (var i = 0; i < options.length; i++) {
        if (options[i].selected == true) {
            args.IsValid = true;
            return;
        }
    }
    args.IsValid = false;
}
 function fnLoad()
        {
            document.getElementById('txtName').focus();

        }
//       function myValidatorHook(validate) {
//    if (!validated) {
//        $("#<% =lblFix.ClientID %>").hide();
//    }
//    else {
//        $("#<% =lblFix.ClientID %>").show();
//    }
//}
//function ToggleVisibility()
//{
//    var element = document.getElementByID('lblFix');

//    if (element.style.display = 'none')
//    {
//        element.style.display = 'inherit';
//    }
//    else
//    {
//        element.style.display = 'none';
//    }
//}
</script> 
                </td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td class="style4">
                    <asp:Button ID="btnSubmit" runat="server" Height="34px" Text="Submit" 
                        Width="96px" onclick="btnSubmit_Click" />
                        
                </td>
            </tr>
        </table>
    
    </div>
    <div>
        <table align="center" class="style1">
        <tr><td>
            <asp:Label ID="lblFix" runat="server" Text=" Please fix the following Errors." Style="display: none;"></asp:Label>
        </td>
        </tr>
            <tr>
                <td>
                    <asp:ValidationSummary ID="ValidationSummary1" ShowMessageBox="false" ShowSummary="true" runat="server" /></td>
            </tr>
        </table>
    </div>
    </form>

    
   
</body>
</html>
