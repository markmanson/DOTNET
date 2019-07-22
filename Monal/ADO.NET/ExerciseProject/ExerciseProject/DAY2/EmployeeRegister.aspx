<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeRegister.aspx.cs" Inherits="ExerciseProject.EmployeeRegister" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Insert/Update</title>
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
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
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
                <asp:Label ID="LbkLName" runat="server" Font-Bold="False" Font-Names="Franklin Gothic Demi Cond" 
                    Font-Size="Small" ForeColor="#0033CC" Text="Last Name:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TxtLname" runat="server" Width="199px"></asp:TextBox>
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
                    onselectionchanged="Cal1_SelectionChanged" Visible="False" Width="88px">
                </asp:Calendar>
                <asp:Button ID="BtnCal1" runat="server" Height="22px" onclick="BtnCal1_Click" 
                    Text="Select Date" Width="89px" />
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
                    onselectionchanged="Cal2_SelectionChanged" Visible="False">
                </asp:Calendar>
                <asp:Button ID="BtnCal2" runat="server" onclick="BtnCal2_Click" 
                    Text="Select Date" Width="83px" />
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
                    onclick="btnSubmit_Click" style="height: 26px" />
                <asp:Button ID="btnReset" runat="server" Text="Reset" Width="114px" 
                    onclick="btnReset_Click" />
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
