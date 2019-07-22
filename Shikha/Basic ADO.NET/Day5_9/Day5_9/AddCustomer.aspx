<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCustomer.aspx.cs" Inherits="Day5_9.AddCustomer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Customer WebPage</title>
</head>
<body onload="fnLoad();">
<script language=javascript>

function fnLoad(){
document.getElementById('txtCustomerID').focus();

}
</script>
    <form id="form1" runat="server" >
   
    <div>
    
 

     <table style="background-color:Aqua" border="1">
    <tr>
     <td>CustomerID:<span style ="color:Red ">*</span></td>
     <td><asp:TextBox ID="txtCustomerID" runat="server" >
        </asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" 
                 runat="server" 
                ControlToValidate="txtCustomerID" Display="None"
               ErrorMessage="CustomerID cant be left blank" 
                SetFocusOnError="True">* CompanyNamecan't be left blank
        </asp:RequiredFieldValidator>
     </td></tr>
     <tr>
     <td>CompanyName:<span style ="color:Red ">*</span></td>
     <td><asp:TextBox ID="txtCompanyName" runat="server" >
        </asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvCompanyName" 
                 runat="server" 
                ControlToValidate="txtCompanyName" Display="None"
               ErrorMessage="CompanyNamecan't be left blank" 
                SetFocusOnError="True">* CompanyNamecan't be left blank
        </asp:RequiredFieldValidator>
    </td></tr>
    <tr>
     <td>ContactName:</td>
     <td><asp:TextBox ID="txtContactName" runat="server" >
        </asp:TextBox>
    
    </td></tr>
    <tr>
     <td>ContactTitle:</td>
     <td><asp:TextBox ID="txtContactTitle" runat="server" >
        </asp:TextBox>
 
    </td></tr>
     <tr><td>Address: </td>
    <td><asp:TextBox ID="txtAddress" runat="server"  
                    TextMode="MultiLine">
        </asp:TextBox>
   
   </td></tr>
    <tr>
     <td>City:</td>
     <td><asp:TextBox ID="txtCity" runat="server" >
        </asp:TextBox>
    <asp:RegularExpressionValidator ID="regexpName" runat="server"     
                                    ErrorMessage="City expression does not validate." 
                                    ControlToValidate="txtCity" Display="None"     
                                    ValidationExpression="^[a-zA-Z'.\s]{1,40}$">
         </asp:RegularExpressionValidator>
    </td>
     </tr>
     <tr>
     <td>Region:</td>
     <td><asp:TextBox ID="txtRegion" runat="server" >
        </asp:TextBox>
   
    </td>
     </tr>
     <tr>
     <td>PostalCode:</td>
     <td><asp:TextBox ID="txtPostalCode" runat="server" >
        </asp:TextBox>
    
        <asp:RegularExpressionValidator   
            ID="RegularExpressionValidator6"  
            runat="server"   
            ValidationExpression="\d{5}(-\d{4})?"  
            ControlToValidate="txtPostalCode"  Display="None"  SetFocusOnError="True"
            ErrorMessage="Input valid U.S. Zip Code!"  
            ></asp:RegularExpressionValidator>
    </td></tr>
     <tr>
     <td>Country:</td>
     <td><asp:TextBox ID="txtCountry" runat="server" >
        </asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"     
                                    ErrorMessage="Country expression does not validate." 
                                    ControlToValidate="txtCountry"  Display="None"   
                                    ValidationExpression="^[a-zA-Z'.\s]{1,40}$">
         </asp:RegularExpressionValidator>
    </td>
     </tr>
    
     <tr><td>Phone:</td>
      <td><asp:TextBox ID="txtPhone" runat="server" >
        </asp:TextBox>
         <asp:RegularExpressionValidator   
            ID="RegularExpressionValidator5"  
            runat="server"   
            ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"  
            ControlToValidate="txtPhone"  Display="None"
            ErrorMessage="Input valid U.S. Phone Number!"  
            ></asp:RegularExpressionValidator> 
        
    </td>
     </tr>
     <tr>
     <td>Fax:</td>
     <td><asp:TextBox ID="txtFax" runat="server" >
        </asp:TextBox>
     </td></tr>
    
      <tr>
     <td>
         <asp:Button ID="btnADD" runat="server" Text="ADD" onclick="btnADD_Click" />
         <asp:ValidationSummary ID="ValidationSummary1" ShowMessageBox="true" ShowSummary="False" runat="server" />
     </td>
     
     <td>
        <%-- <asp:Button ID="btnCncl" runat="server" Text="CANCEL" />--%>
         <input id="ResetAddCust" type="reset" value="RESET" />
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
