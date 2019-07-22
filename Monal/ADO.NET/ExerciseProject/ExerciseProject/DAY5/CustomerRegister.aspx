<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerRegister.aspx.cs" Inherits="ExerciseProject.Day5.CustomerRegister" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
   <title>Insert/Update with validation in customer</title>
    <style type="text/css">
       .style1
        {
            width: 5%;
            border-style:groove;
            background-color:InactiveCaptionText;
           
        }
        .style2
        {
            width: 100%;
        }
         .span
        {
           azimuth:center;
           color:#FF0000;
           font-size:larger;
           margin-top:auto;
           margin-left:auto;
           margin-right:auto;
           
          
        }
    </style>
    <script type="text/javascript" language="javascript">
    function SetFocus()
    {
        ValidationForm.TxtCompanyName.focus();
        return true;
    }
    function validate_required(field,alerttxt)
    {
        with (field)
        {
            if (value==null||value=="")
            {
                alert(alerttxt);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
    function Valid_Value(field,alerttxt)
    {
        with(field)
        {
            if(value!="")
            {
                var Name=/([A-Za-z\'\ ])/;
	            var notvalidvalue=/([0-9\`~!#$@%^&*(){}[]|_\-\.])/;	
	            var validname=field.value;
	            if ((Name.test(validname)==false)  || (notvalidvalue.test(validname)==true))
	            {
		            alert(alerttxt);
		            return false;
	             }	             
	             else
                 {
                   return true;
                 }	            
            }
        }
    }
    function validationvalue()
    {
        with(ValidationForm)
        {
            var CompanyName=TxtCompanyName.value.length;
            var ContactName=TxtContactName.value.length;
            var ContactTitleValue=TxtContactTitle.value.length;
            var Address=TxtAddress.value.length;
            var City=TxtCity.value.length;
            var Region=TxtRegion.value.length;
            var PostalCode=TxtPostalCode.value.length;
            var Country=TxtCountry.value.length;
            var Phone=TxtPhone.value.length;
            var Fax=TxtFax.value.length;
            if (validate_required(TxtCompanyName,"Company Name must be filled out!")==false)
                    {TxtCompanyName.focus();return false;}
            if(Valid_Value(TxtCompanyName,"Please Enter valid Company Name!")==false)   
               {   TxtCompanyName.focus();TxtCompanyName.select(); return false;}  
            if(CompanyName > 40)
	        {
		        alert("Please enter only maximum 40 characters");
		        TxtCompanyName.focus();
		        TxtCompanyName.select();
		        return false;
	        }
//            if(validate_required(TxtContactName,"First Name must be filled out!")==false)
//                    {TxtContactName.focus();return false;}
            if(Valid_Value(TxtContactName,"Please Enter valid Contact Name!")==false)   
               {   TxtContactName.focus();TxtContactName.select(); return false;}  
            if(ContactName > 30)
	        {
		        alert("Please enter only maximum 30 characters");
		        TxtContactName.focus();
		        TxtContactName.select();
		        return false;
	        }
	         if(Valid_Value(TxtContactTitle,"Please Enter valid Title!")==false)   
               {   TxtContactTitle.focus();TxtContactTitle.select(); return false;}  
            if(ContactTitleValue > 30)
	        {
		        alert("Please enter only maximum 30 characters");
		        TxtContactTitle.focus();
		        TxtContactTitle.select();
		        return false;
	        }
            if(Address > 60)
	        {
		        alert("Please enter only maximum 60 characters");
		        TxtAddress.focus();
		        TxtAddress.select();
		        return false;
	        }
	         if(Valid_Value(TxtCity,"Please Enter valid City Name!")==false)   
               {   TxtCity.focus();TxtCity.select(); return false;}  
	        if(City > 15)
	        {
		        alert("Please enter only maximum 15 characters");
		        TxtCity.focus();
		        TxtCity.select();
		        return false;
	        }
	        if(Valid_Value(TxtRegion,"Please Enter valid Region!")==false)   
               {   TxtRegion.focus();TxtRegion.select(); return false;}  
	        if(Region > 15)
	        {
		        alert("Please enter only maximum 15 characters");
		        TxtRegion.focus();
		        TxtRegion.select();
		        return false;
	        }
	        if(TxtPostalCode.value.match(/([`~!#$@%^&*(){}[]|_\.])/))
	        {
	            alert("Please enter valid postal code");
		        TxtPostalCode.focus();
		        TxtPostalCode.select();
		        return false;
	        }
	        if(PostalCode > 10)
	        {
		        alert("Please enter only maximum 10 characters");
		        TxtPostalCode.focus();
		        TxtPostalCode.select();
		        return false;
	        }
	        if(Valid_Value(TxtCountry,"Please Enter valid Country Name!")==false)   
               {  TxtCountry.focus();TxtCountry.select(); return false;}  
            if(Country > 15)
	        {
		        alert("Please enter only maximum 15 characters");
		        TxtCountry.focus();
		        TxtCountry.select();
		        return false;
	        }
	        if( TxtPhone.value.match(/([A-Za-z\`~!#$@%^&*{}[]|_\.])/))
	        {
	            alert("Please enter valid Phone Number");
		        TxtPhone.focus();
		        TxtPhone.select();
		        return false;
	        }
	        if(Phone > 24)
	        {
		        alert("Please enter only maximum 24 Numeric value");
		        TxtPhone.focus();
		        TxtPhone.select();
		        return false;
	        }
	         if( TxtFax.value.match(/([A-Za-z\`~!#$@%^&*{}[]|_\.])/))
	        {
	            alert("Please enter valid numeric value of Fax");
		        TxtFax.focus();
		        TxtFax.select();
		        return false;
	        }
	        if(Fax > 24)
	        {
		        alert("Please enter only maximum 24 Numeric value");
		        TxtFax.focus();
		        TxtFax.select();
		        return false;
	        }
	       
	         else
	        {
	            return true;
	        }
        }
    }

    </script>
</head>
<body onload="return SetFocus();">
    <form id="ValidationForm" runat="server" method="post">
    <div>
     <asp:Label ID="LblErrorMessage" runat="server" Text="Label" CssClass="span"></asp:Label>
    </div>
    <div align="center">
    <asp:Panel runat="server" ID="pnlPanelTable">
        <table align="center" cellspacing="3" class="style1" bgcolor="White">
        <tr>
            <td colspan="2" bgcolor="White">
                <asp:Label ID="LblNewUser" runat="server" Text="Customer Form" Font-Bold="True" 
                    Font-Names="Arial Rounded MT Bold" Font-Size="Medium" Font-Underline="True" 
                    ForeColor="#0033CC"></asp:Label>
            </td>
        </tr>
        <tr bgcolor="White">
            <td class="style2">
                <asp:Label ID="LblCompanyName" runat="server"  Font-Bold="False" Font-Names="Franklin Gothic Demi Cond" 
                    Font-Size="Small" ForeColor="#0033CC" Text="Company Name:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TxtCompanyName"  runat="server" Width="199px"></asp:TextBox>
            </td>
        </tr>
        <tr bgcolor="White">
            <td class="style2">
                <asp:Label ID="LblContactName" runat="server" Font-Bold="False" Font-Names="Franklin Gothic Demi Cond" 
                    Font-Size="Small" ForeColor="#0033CC" Text="Contact Name:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TxtContactName" runat="server" Width="199px"></asp:TextBox></td>
        </tr>
         <tr bgcolor="White">
            <td class="style2">
                <asp:Label ID="LblContactTitle" runat="server" Font-Bold="False" Font-Names="Franklin Gothic Demi Cond" 
                    Font-Size="Small" ForeColor="#0033CC" Text="Contact Title:"></asp:Label>
            </td>
            <td>
               <asp:TextBox ID="TxtContactTitle" runat="server" Width="199px"></asp:TextBox></td>
        </tr>
         
         <tr bgcolor="White">
            <td class="style2">
                <asp:Label ID="LblAddress" Font-Bold="False" Font-Names="Franklin Gothic Demi Cond" 
                    Font-Size="Small" ForeColor="#0033CC" runat="server" Text="Address:"></asp:Label>
            </td>
            <td>
               <asp:TextBox ID="TxtAddress" TextMode="MultiLine" runat="server" Width="199px"></asp:TextBox></td>
        </tr>
         <tr bgcolor="White">
            <td class="style2">
                <asp:Label ID="LblCity" runat="server" Font-Bold="False" Font-Names="Franklin Gothic Demi Cond" 
                    Font-Size="Small" ForeColor="#0033CC" Text="City:"></asp:Label>
            </td>
            <td>
                 <asp:TextBox ID="TxtCity" runat="server" Width="199px"></asp:TextBox></td>
        </tr>
         <tr bgcolor="White">
            <td class="style2">
                <asp:Label ID="LblRegion" runat="server" Font-Bold="False" Font-Names="Franklin Gothic Demi Cond" 
                    Font-Size="Small" ForeColor="#0033CC" Text="Region:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TxtRegion" runat="server" Width="199px"></asp:TextBox></td>
        </tr>
         <tr bgcolor="White">
            <td class="style2">
                <asp:Label ID="LblPostCode" runat="server" Font-Bold="False" Font-Names="Franklin Gothic Demi Cond" 
                    Font-Size="Small" ForeColor="#0033CC" Text="Postal Code:"></asp:Label>
            </td>
            <td>
                 <asp:TextBox ID="TxtPostalCode" runat="server" Width="199px"></asp:TextBox></td>
        </tr>
         <tr bgcolor="White">
            <td class="style2">
                <asp:Label ID="LblCountry" runat="server" Font-Bold="False" Font-Names="Franklin Gothic Demi Cond" 
                    Font-Size="Small" ForeColor="#0033CC" Text="Country:"></asp:Label>
            </td>
            <td>
                 <asp:TextBox ID="TxtCountry" runat="server" Width="199px"></asp:TextBox></td>
        </tr>
         <tr bgcolor="White">
            <td class="style2">
                <asp:Label ID="LblPhone" runat="server" Font-Bold="False" Font-Names="Franklin Gothic Demi Cond" 
                    Font-Size="Small" ForeColor="#0033CC" Text="Phone:"></asp:Label>
            </td>
            <td>
                 <asp:TextBox ID="TxtPhone" runat="server" Width="199px"></asp:TextBox></td>
        </tr>
         <tr bgcolor="White">
            <td class="style2">
                <asp:Label ID="LblFax" runat="server" Font-Bold="False" Font-Names="Franklin Gothic Demi Cond" 
                    Font-Size="Small" ForeColor="#0033CC" Text="Fax:"></asp:Label>
            </td>
            <td>
                 <asp:TextBox ID="TxtFax" runat="server" Width="199px"></asp:TextBox></td>
        </tr>
        
         <tr bgcolor="White">
            <td colspan="2">
                &nbsp;</td>
        </tr>
         <tr bgcolor="White">
            <td colspan="2">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="101px"  
                    OnClientClick="return validationvalue();" onclick="btnSubmit_Click"/>
               
                <asp:Button ID="btnReset" runat="server" Text="Reset" Width="114px" onclick="btnReset_Click"  
                    />
             </td>
        </tr>
    </table>
   </asp:Panel>
    </div>
    <br />
    <br/>
    </form>
</body>
</html>
