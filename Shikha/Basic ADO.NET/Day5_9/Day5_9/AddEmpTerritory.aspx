<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddEmpTerritory.aspx.cs" Inherits="Day5_9.AddEmpTerritory" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>AddEmpTerritory Webpage</title>

</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table style="background-color:Aqua" border="1" >
    <tr>
     <td id="tblemp" runat="server">EmployeeID:</td>
     <td><asp:TextBox ID="txtEmployeeID"  runat="server" >
        </asp:TextBox>
     </td></tr>
     <tr>
     <td>TitleOfCourtesy:<span style ="color:Red ">*</span></td>
     <td><asp:DropDownList ID="ddlTitleOfCourtesy" runat="server" width="145px" >

<asp:ListItem Text="Mr." Value="Mr." Selected="true"></asp:ListItem>
<asp:ListItem Text="Miss." Value="Miss." Selected="False"></asp:ListItem>
<asp:ListItem Text="Mrs." Value="Mrs." Selected="False"></asp:ListItem>
<asp:ListItem Text="Dr." Value="Dr." Selected="False"></asp:ListItem>

</asp:DropDownList>
     </td>
     </tr>
    <tr>
     <td>First Name:<span style ="color:Red ">*</span> </td>
     <td><asp:TextBox ID="txtFirstName" runat="server" >
        </asp:TextBox>
     </td>
     <td><asp:RequiredFieldValidator ID="rfvFirstName" 
                 runat="server" 
                ControlToValidate="txtFirstName"
               ErrorMessage="First Name can't be left blank" 
                SetFocusOnError="True">* First Name can't be left blank
        </asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator ID="regexpName" runat="server"     
                                    ErrorMessage="This expression does not validate." 
                                    ControlToValidate="txtFirstName"     
                                    ValidationExpression="^[a-zA-Z'.\s]{1,40}$">
         </asp:RegularExpressionValidator>
    </td>
    </tr>
   <tr>
    <td>Last Name:<span style ="color:Red ">*</span></td>
    <td><asp:TextBox ID="txtLastName" runat="server" >
       </asp:TextBox></td>
   <td><asp:RequiredFieldValidator 
            ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txtLastName"
           ErrorMessage="Last Name can't be left blank" 
             SetFocusOnError="True">* Last Name can't be left blank
        </asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"     
                                    ErrorMessage="This expression does not validate." 
                                    ControlToValidate="txtLastName"     
                                    ValidationExpression="^[a-zA-Z'.\s]{1,40}$">
         </asp:RegularExpressionValidator>
    </td></tr>
     <tr>
     <td>Title:<span style ="color:Red ">*</span></td>
     <td><asp:DropDownList ID="ddlTitle" runat="server" width="145px" >

<asp:ListItem Text="Sales Representative" Value="Sales Representative" Selected="true"></asp:ListItem>
<asp:ListItem Text="Vice President, Sales" Value="Vice President, Sales" Selected="False"></asp:ListItem>
<asp:ListItem Text="Sales Manager" Value="Sales Manager" Selected="False"></asp:ListItem>
<asp:ListItem Text="Inside Sales Coordinator" Value="Inside Sales Coordinator" Selected="False"></asp:ListItem>

</asp:DropDownList>
     </td>
    
     </tr>
     <tr><td> Birth Date:<span style ="color:Red ">*</span></td>
     
       <td>
           <asp:ScriptManager ID="ScriptManager1" runat="server">
           </asp:ScriptManager>
<asp:TextBox ID="txtBirthDate" runat="server" ></asp:TextBox>  

<ajaxToolkit:CalendarExtender   runat="server" ID="CalendarExtender1" PopupButtonID="imgCal1" TargetControlID="txtBirthDate"
                    Format="MM/dd/yyyy">
                </ajaxToolkit:CalendarExtender>

     </td>
      <td><asp:RequiredFieldValidator ID="rfvtxtBirthDate" 
                 runat="server" 
                ControlToValidate="txtBirthDate"
               ErrorMessage=" " 
                SetFocusOnError="True">*
        </asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="dateValRegex" runat="server" ControlToValidate="txtBirthDate" ErrorMessage="Please Enter a valid date in the format (mm/dd/yyyy)" ValidationExpression="^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$">
        </asp:RegularExpressionValidator>
    </td>
     </tr>
      <tr>
     <td>HireDate:<span style ="color:Red ">*</span></td>
     <td>
     <asp:TextBox ID="txtHireDate" runat="server" >
        </asp:TextBox>
        <ajaxToolkit:CalendarExtender   runat="server" ID="CalendarExtender2" PopupButtonID="imgCal1" TargetControlID="txtHireDate"
                    Format="MM/dd/yyyy">
                </ajaxToolkit:CalendarExtender>
     </td>
      <td><asp:RequiredFieldValidator ID="rfvtxtHireDate" 
                 runat="server" 
                ControlToValidate="txtHireDate"
               ErrorMessage=" " 
                SetFocusOnError="True">*
        </asp:RequiredFieldValidator>
       <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtHireDate" ErrorMessage="Please Enter a valid date in the format (mm/dd/yyyy)" ValidationExpression="^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$">
        </asp:RegularExpressionValidator> 
    </td>
     </tr>
     <tr><td>Address:<span style ="color:Red ">*</span> </td>
    <td><asp:TextBox ID="txtAddress" runat="server" 
                    TextMode="MultiLine">
        </asp:TextBox>
   </td>
    <td><asp:RequiredFieldValidator ID="rfvAddress" 
             runat="server" 
             ControlToValidate="txtAddress"
             ErrorMessage=" " 
            SetFocusOnError="True">*Address can't be left blank
        </asp:RequiredFieldValidator>
        
   </td></tr>
    <tr>
     <td>City:<span style ="color:Red ">*</span></td>
     <td><asp:TextBox ID="txtCity" runat="server" >
        </asp:TextBox>
     </td> <td><asp:RequiredFieldValidator ID="rfvtxtCity" 
                 runat="server" 
                ControlToValidate="txtCity"
               ErrorMessage=" " 
                SetFocusOnError="True">*
        </asp:RequiredFieldValidator>
    </td>
     </tr>
     <tr>
     <td>Region:<span style ="color:Red ">*</span></td>
     <td><asp:TextBox ID="txtRegion" runat="server" >
        </asp:TextBox>
     </td>
     <td><asp:RequiredFieldValidator ID="rfvtxtRegion" 
                 runat="server" 
                ControlToValidate="txtRegion"
               ErrorMessage=" " 
                SetFocusOnError="True">*
        </asp:RequiredFieldValidator>
    </td>
     </tr>
     <tr>
     <td>PostalCode:<span style ="color:Red ">*</span></td>
     <td><asp:TextBox ID="txtPostalCode" runat="server" >
        </asp:TextBox>
     </td>
       <td><asp:RequiredFieldValidator ID="rfvtxtPostalCode" 
                 runat="server" 
                ControlToValidate="txtPostalCode"
               ErrorMessage=" " 
                SetFocusOnError="True">*
        </asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator   
            ID="RegularExpressionValidator6"  
            runat="server"   
            ValidationExpression="\d{5}(-\d{4})?"  
            ControlToValidate="txtPostalCode"  
            ErrorMessage="Input valid U.S. Zip Code!"  
            ></asp:RegularExpressionValidator>
    </td></tr>
     <tr>
     <td>Country:<span style ="color:Red ">*</span></td>
     <td><asp:TextBox ID="txtCountry" runat="server" >
        </asp:TextBox>
     </td> <td><asp:RequiredFieldValidator ID="rfvtxtCountry" 
                 runat="server" 
                ControlToValidate="txtCountry"
               ErrorMessage=" " 
                SetFocusOnError="True">*
        </asp:RequiredFieldValidator>
    </td>
     </tr>
     <tr>
     <td>HomePhone:<span style ="color:Red ">*</span></td>
     <td><asp:TextBox ID="txtHomePhone" runat="server" >
        </asp:TextBox>
     </td> <td><asp:RequiredFieldValidator ID="rfvtxtHomePhone" 
                 runat="server" 
                ControlToValidate="txtHomePhone"
               ErrorMessage=" " 
                SetFocusOnError="True">*
        </asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator   
            ID="RegularExpressionValidator5"  
            runat="server"   
            ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"  
            ControlToValidate="txtHomePhone"  
            ErrorMessage="Input valid U.S. Phone Number!"  
            ></asp:RegularExpressionValidator> 
    </td>
     </tr>
     <tr>
     <td>Extension:<span style ="color:Red ">*</span></td>
     <td><asp:TextBox ID="txtExtension" runat="server">
        </asp:TextBox>
     </td><td><asp:RequiredFieldValidator ID="rfvtxtExtension" 
                 runat="server" 
                ControlToValidate="txtExtension"
               ErrorMessage=" " 
                SetFocusOnError="True">*
        </asp:RequiredFieldValidator>
    </td>
     </tr>
     <tr>
     <td>Photo:</td>
     <td><asp:TextBox ID="txtPhoto" runat="server">
        </asp:TextBox>
     </td></tr>
     <tr>
     <td>Notes:<span style ="color:Red ">*</span></td>
     <td><asp:TextBox ID="txtNotes" TextMode="MultiLine" runat="server">
        </asp:TextBox>
     </td></tr>
     <tr>
     <td>ReportsTo:</td>
     <td><asp:TextBox ID="txtReportsTo" runat="server" >
        </asp:TextBox>
     </td><td><asp:RequiredFieldValidator ID="rfvtxtReportsTo" 
                 runat="server" 
                ControlToValidate="txtReportsTo"
               ErrorMessage=" " 
                SetFocusOnError="True">*
        </asp:RequiredFieldValidator>
    </td>
     </tr>
      <tr>
     <td>PhotoPath:</td>
     <td><asp:TextBox ID="txtPhotoPath" runat="server">
        </asp:TextBox>
     </td></tr>
     <tr>
     <td>TerritoryDescription:</td>
     <td>
         <asp:ListBox ID="lstTerritoryDescription" SelectionMode="Multiple" runat="server"></asp:ListBox></td>
  <%--  <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
                 runat="server" 
                ControlToValidate="txtTerritoryDescription"
               ErrorMessage=" " 
                SetFocusOnError="True">*
        </asp:RequiredFieldValidator>
    </td>--%>
     </tr>
     <tr>
     <td>
         <asp:Button ID="btnADD" runat="server" Text="ADD" onclick="btnADD_Click" />
     </td>
     
     <td>
        <%-- <asp:Button ID="btnCncl" runat="server" Text="CANCEL" onclick="btnCncl_Click" />--%>
         <input id="ResetEmpter" type="reset" value="RESET" onclick="return ResetEmpter_onclick()" />
     </td>
     </tr>
     <tr><td>
         <asp:Label ID="lblUpdate" runat="server" Text="Label" Visible="false"></asp:Label>
         <asp:Label ID="lblInsert" runat="server" Text="Label" Visible="false"></asp:Label>
     </td>
     </tr>
    </table>
    
    </div>
    </form>
</body>
</html>
