<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_Emp.aspx.cs" Inherits="Day_2_4.Add_Emp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>AddInfo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <table>
    <tr>
     <td>EmployeeID:</td>
     <td><asp:TextBox ID="txtEmployeeID" runat="server">
        </asp:TextBox>
     </td></tr>
     <tr>
     <td>TitleOfCourtesy:</td>
     <td><asp:TextBox ID="txtTitleOfCourtesy" runat="server">
        </asp:TextBox>
     </td></tr>
    <tr>
     <td>First Name:</td>
     <td><asp:TextBox ID="txtFirstName" runat="server">
        </asp:TextBox>
     </td>
     <td><asp:RequiredFieldValidator ID="rfvFirstName" 
                 runat="server" 
                ControlToValidate="txtFirstName"
               ErrorMessage="First Name can't be left blank" 
                SetFocusOnError="True">*
        </asp:RequiredFieldValidator>
    </td>
    </tr>
   <tr>
    <td>Last Name:</td>
    <td><asp:TextBox ID="txtLastName" runat="server">
       </asp:TextBox></td>
   <td><asp:RequiredFieldValidator 
            ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txtLastName"
           ErrorMessage="Last Name can't be left blank" 
             SetFocusOnError="True">*
        </asp:RequiredFieldValidator>
    </td></tr>
     <tr>
     <td>Title:</td>
     <td><asp:TextBox ID="txtTitle" runat="server">
        </asp:TextBox>
     </td></tr>
     <tr><td> Birth Date</td>
     
       <td>
           <asp:ScriptManager ID="ScriptManager1" runat="server">
           </asp:ScriptManager>
<asp:TextBox ID="txtBirthDate" runat="server"></asp:TextBox>  

<ajaxToolkit:CalendarExtender   runat="server" ID="CalendarExtender1" PopupButtonID="imgCal1" TargetControlID="txtBirthDate"
                    Format="MM/dd/yyyy">
                </ajaxToolkit:CalendarExtender>

     </td>
     </tr>
      <tr>
     <td>HireDate:</td>
     <td>
     <asp:TextBox ID="txtHireDate" runat="server">
        </asp:TextBox>
        <ajaxToolkit:CalendarExtender   runat="server" ID="CalendarExtender2" PopupButtonID="imgCal1" TargetControlID="txtHireDate"
                    Format="MM/dd/yyyy">
                </ajaxToolkit:CalendarExtender>
     </td></tr>
     <tr><td>Address:</td>
    <td><asp:TextBox ID="txtAddress" runat="server" 
                    TextMode="MultiLine">
        </asp:TextBox>
   </td>
    <td><asp:RequiredFieldValidator ID="rfvAddress" 
             runat="server" 
             ControlToValidate="txtAddress"
             ErrorMessage="Address can't be left blank" 
            SetFocusOnError="True">*
        </asp:RequiredFieldValidator>
   </td></tr>
    <tr>
     <td>City:</td>
     <td><asp:TextBox ID="txtCity" runat="server">
        </asp:TextBox>
     </td></tr>
     <tr>
     <td>Region:</td>
     <td><asp:TextBox ID="txtRegion" runat="server">
        </asp:TextBox>
     </td></tr>
     <tr>
     <td>PostalCode:</td>
     <td><asp:TextBox ID="txtPostalCode" runat="server">
        </asp:TextBox>
     </td></tr>
     <tr>
     <td>Country:</td>
     <td><asp:TextBox ID="txtCountry" runat="server">
        </asp:TextBox>
     </td></tr>
     <tr>
     <td>HomePhone:</td>
     <td><asp:TextBox ID="txtHomePhone" runat="server">
        </asp:TextBox>
     </td></tr>
     <tr>
     <td>Extension:</td>
     <td><asp:TextBox ID="txtExtension" runat="server">
        </asp:TextBox>
     </td></tr>
     <tr>
     <td>Photo:</td>
     <td><asp:TextBox ID="txtPhoto" runat="server">
        </asp:TextBox>
     </td></tr>
     <tr>
     <td>Notes:</td>
     <td><asp:TextBox ID="txtNotes" runat="server">
        </asp:TextBox>
     </td></tr>
     <tr>
     <td>ReportsTo:</td>
     <td><asp:TextBox ID="txtReportsTo" runat="server">
        </asp:TextBox>
     </td></tr>
      <tr>
     <td>PhotoPath:</td>
     <td><asp:TextBox ID="txtPhotoPath" runat="server">
        </asp:TextBox>
     </td></tr>
     <tr>
     <td>
         <asp:Button ID="btnADD" runat="server" Text="ADD" onclick="btnADD_Click" />
     </td>
     
     <td>
         <asp:Button ID="btnCncl" runat="server" Text="CANCEL" onclick="btnCncl_Click" />
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
