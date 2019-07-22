<%@ Page Language="C#" AutoEventWireup="true"  CodeBehind="EmployeeRegisterValidation.aspx.cs" Inherits="ExerciseProject.Day5.EmployeeRegisterValidation" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
   <title>Insert/Update with validation</title>
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
        ValidationForm.TxtLname.focus();
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
            var LNameValue=TxtLname.value.length;
            var FNameValue=TxtFname.value.length;
            var TitleValue=TxtTitle.value.length;
            var Address=TxtAddress.value.length;
            var City=TxtCity.value.length;
            var Region=TxtRegion.value.length;
            var PostalCode=TxtPostalCode.value.length;
            var Country=TxtCountry.value.length;
            var HomePhone=TxtHomePhone.value.length;
            var Extension=TxtExtension.value.length;
            if (validate_required(TxtLname,"Last Name must be filled out!")==false)
                    {TxtLname.focus();return false;}
            if(Valid_Value(TxtLname,"Please Enter valid Last Name!")==false)   
               {   TxtLname.focus();TxtLname.select(); return false;}  
            if(LNameValue > 20)
	        {
		        alert("Please enter only maximum 20 characters");
		        TxtLname.focus();
		        TxtLname.select();
		        return false;
	        }
            if(validate_required(TxtFname,"First Name must be filled out!")==false)
                    {TxtFname.focus();return false;}
            if(Valid_Value(TxtFname,"Please Enter valid First Name!")==false)   
               {   TxtFname.focus();TxtFname.select(); return false;}  
            if(FNameValue > 10)
	        {
		        alert("Please enter only maximum 10 characters");
		        TxtFname.focus();
		        TxtFname.select();
		        return false;
	        }
	         if(Valid_Value(TxtTitle,"Please Enter valid Title!")==false)   
               {   TxtTitle.focus();TxtTitle.select(); return false;}  
            if(TitleValue > 30)
	        {
		        alert("Please enter only maximum 30 characters");
		        TxtTitle.focus();
		        TxtTitle.select();
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
	        if(TxtPostalCode.value.match(/([`~!#$@%^&*(){}[]|_\-\.])/))
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
	        if( TxtHomePhone.value.match(/([A-Za-z\`~!#$@%^&*{}[]|_\.])/))
	        {
	            alert("Please enter valid Home Phone");
		        TxtHomePhone.focus();
		        TxtHomePhone.select();
		        return false;
	        }
	        if(HomePhone > 24)
	        {
		        alert("Please enter only maximum 24 Numeric value");
		        TxtHomePhone.focus();
		        TxtHomePhone.select();
		        return false;
	        }
	         if( TxtExtension.value.match(/([A-Za-z\`~!#$@%^&*(){}[]|_\-\.])/))
	        {
	            alert("Please enter valid numeric value of Extension");
		        TxtExtension.focus();
		        TxtExtension.select();
		        return false;
	        }
	        if(Extension > 4)
	        {
		        alert("Please enter only maximum 4 characters");
		        TxtExtension.focus();
		        TxtExtension.select();
		        return false;
	        }
	        if(TxtReportsTo.value.match(/([A-Za-z\`~!#$@%^&*(){}[]|_\-\.])/))
	        {
	            alert("Please enter valid numeric value of Reports To");
		        TxtReportsTo.focus();
		        TxtReportsTo.select();
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
                <asp:Label ID="LblNewUser" runat="server" Text="Employee Form" Font-Bold="True" 
                    Font-Names="Arial Rounded MT Bold" Font-Size="Medium" Font-Underline="True" 
                    ForeColor="#0033CC"></asp:Label>
            </td>
        </tr>
        <tr bgcolor="White">
            <td class="style2">
                <asp:Label ID="LblLName" runat="server"  Font-Bold="False" Font-Names="Franklin Gothic Demi Cond" 
                    Font-Size="Small" ForeColor="#0033CC" Text="Last Name:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TxtLname"  runat="server" Width="199px"></asp:TextBox>
            </td>
        </tr>
        <tr bgcolor="White">
            <td class="style2">
                <asp:Label ID="LblFName" runat="server" Font-Bold="False" Font-Names="Franklin Gothic Demi Cond" 
                    Font-Size="Small" ForeColor="#0033CC" Text="FirstName:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TxtFname" runat="server" Width="199px"></asp:TextBox></td>
        </tr>
         <tr bgcolor="White">
            <td class="style2">
                <asp:Label ID="LblTitle" runat="server" Font-Bold="False" Font-Names="Franklin Gothic Demi Cond" 
                    Font-Size="Small" ForeColor="#0033CC" Text="Title:"></asp:Label>
            </td>
            <td>
               <asp:TextBox ID="TxtTitle" runat="server" Width="199px"></asp:TextBox></td>
        </tr>
         <tr bgcolor="White">
            <td class="style2">
                <asp:Label ID="LblSalutation" runat="server" Font-Bold="False" Font-Names="Franklin Gothic Demi Cond" 
                    Font-Size="Small" ForeColor="#0033CC" Text="Salutation:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DdlSalutation" runat="server" Height="16px" Width="199px">
                    <asp:ListItem Selected="True">Select</asp:ListItem>
                    <asp:ListItem>Mr.</asp:ListItem>
                    <asp:ListItem>Mrs.</asp:ListItem>
                    <asp:ListItem>Miss</asp:ListItem>
                </asp:DropDownList>
              </td>
        </tr>
         <tr bgcolor="White">
            <td class="style2">
                <asp:Label ID="LblBdate" Font-Bold="False" Font-Names="Franklin Gothic Demi Cond" 
                    Font-Size="Small" ForeColor="#0033CC" runat="server" Text="Birth Date:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TxtBdate" runat="server" Width="85px"></asp:TextBox>
                <asp:Calendar ID="Cal1" runat="server" Height="68px" 
                     Visible="False" Width="88px" onselectionchanged="Cal1_SelectionChanged">
                </asp:Calendar>
                <asp:Button ID="BtnCal1" runat="server" Height="22px" 
                    Text="Select Date" Width="89px" onclick="BtnCal1_Click" />
             </td>
        </tr>
         <tr bgcolor="White">
            <td class="style2">
                <asp:Label ID="LblHDate" Font-Bold="False" Font-Names="Franklin Gothic Demi Cond" 
                    Font-Size="Small" ForeColor="#0033CC"   runat="server" Text="Hire Date:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TxtHDate" runat="server" Width="85px"></asp:TextBox>
                <asp:Calendar ID="Cal2" runat="server" 
                    Visible="False" onselectionchanged="Cal2_SelectionChanged">
                </asp:Calendar>
                <asp:Button ID="BtnCal2" runat="server"
                    Text="Select Date" Width="83px" onclick="BtnCal2_Click" />
            </td>
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
                <asp:Label ID="LblPh" runat="server" Font-Bold="False" Font-Names="Franklin Gothic Demi Cond" 
                    Font-Size="Small" ForeColor="#0033CC" Text="Home Phone:"></asp:Label>
            </td>
            <td>
                 <asp:TextBox ID="TxtHomePhone" runat="server" Width="199px"></asp:TextBox></td>
        </tr>
         <tr bgcolor="White">
            <td class="style2">
                <asp:Label ID="LblExtension" runat="server" Font-Bold="False" Font-Names="Franklin Gothic Demi Cond" 
                    Font-Size="Small" ForeColor="#0033CC" Text="Extension:"></asp:Label>
            </td>
            <td>
                 <asp:TextBox ID="TxtExtension" runat="server" Width="199px"></asp:TextBox></td>
        </tr>
         <tr bgcolor="White">
            <td class="style2">
                <asp:Label ID="LblNotes" runat="server" Font-Bold="False" Font-Names="Franklin Gothic Demi Cond" 
                    Font-Size="Small" ForeColor="#0033CC" Text="Notes:"></asp:Label>
            </td>
            <td>
                 <asp:TextBox ID="TxtNotes" runat="server" Width="199px"></asp:TextBox></td>
        </tr>
         <tr bgcolor="White">
            <td class="style2">
                 <asp:Label ID="LblReport" runat="server" Font-Bold="False" Font-Names="Franklin Gothic Demi Cond" 
                    Font-Size="Small" ForeColor="#0033CC" Text="Reports To:"></asp:Label></td>
            <td>
                 <asp:TextBox ID="TxtReportsTo" runat="server" Width="199px"></asp:TextBox></td>
        </tr>
         <tr bgcolor="White">
            <td colspan="2">
                &nbsp;</td>
        </tr>
         <tr bgcolor="White">
            <td colspan="2">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="101px"  
                    style="height: 26px" onclick="btnSubmit_Click"  OnClientClick="return validationvalue();"/>
               
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
