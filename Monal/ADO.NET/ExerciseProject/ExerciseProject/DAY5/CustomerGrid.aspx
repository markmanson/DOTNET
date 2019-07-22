<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerGrid.aspx.cs" Inherits="ExerciseProject.Day5.CustomerGrid" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
      <title>DAY-5-3(Customer Grid with DML operation)</title>
        <style type="text/css">
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
 
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="LblErrorMessage" runat="server" Text="Label" CssClass="span"></asp:Label>
    
    <asp:LinkButton Visible="true" ID="LnkAddNewUser" runat="server" 
                       onclick="LnkAddNewUser_Click">New User?</asp:LinkButton>
    <asp:GridView ID="GrdCustomer" Font-Bold="True" 
     BorderStyle="Solid"
     AlternatingRowStyle-Font-Bold="true"
     HeaderStyle-BackColor="ActiveCaptionText" 
     AlternatingRowStyle-BorderStyle="Solid" 
     AlternatingRowStyle-ForeColor="CadetBlue" 
     HeaderStyle-Font-Bold="true" 
     HeaderStyle-Font-Size="Larger" 
     HeaderStyle-ForeColor="CadetBlue" 
     AlternatingRowStyle-Font-Names="Times New Roman, Times, serif"
     AlternatingRowStyle-BackColor="ActiveCaptionText" 
     BackColor="Azure"     
     runat="server" 
     Width="70%" AutoGenerateColumns="False" DataKeyNames="CustomerID" 
            ShowFooter="True" onrowediting="GrdCustomer_RowEditing" 
            onrowdeleting="GrdCustomer_RowDeleting">
     
        <Columns>
       
            <asp:TemplateField HeaderText="Customer ID" Visible="false">
                <ItemTemplate>
                    <asp:Label ID="LblCustId" runat="server" Visible="false" Text='<%# bind("CustomerID")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
           
           <asp:TemplateField HeaderText="CompanyName" ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="LblCompnyName" runat="server" Text='<%# bind("CompanyName")%>'></asp:Label>
                </ItemTemplate>
                <%--<FooterTemplate>
                <asp:LinkButton EnableTheming="true" ID="LnkAddNewUser" runat="server" 
                        CommandName="NewUser"' onclick="LnkAddNewUser_Click">New User?</asp:LinkButton>
            </FooterTemplate>--%><ControlStyle Width="5px"></ControlStyle>


            </asp:TemplateField>    
             <asp:TemplateField HeaderText="ContactName" ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="LblContactName" runat="server" Text='<%# bind("ContactName")%>'></asp:Label>
                </ItemTemplate>
                <%--<FooterTemplate>
                <asp:LinkButton EnableTheming="true" ID="LnkAddNewUser" runat="server" 
                        CommandName="NewUser"' onclick="LnkAddNewUser_Click">New User?</asp:LinkButton>
            </FooterTemplate>--%>

            </asp:TemplateField>           
            <asp:TemplateField HeaderText="ContactTitle" ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="LblContactTitle" runat="server" Text='<%# bind("ContactTitle")%>'></asp:Label>
                </ItemTemplate>

<ControlStyle Width="5px"></ControlStyle>

            </asp:TemplateField>
           
         
          
            <asp:TemplateField HeaderText="Address" ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="LblAddress" runat="server" Text='<%# bind("Address")%>'></asp:Label>
                </ItemTemplate>

<ControlStyle Width="5px"></ControlStyle>

            </asp:TemplateField>
            <asp:TemplateField HeaderText="City" ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="LblCity" runat="server" Text='<%# bind("City")%>'></asp:Label>
                </ItemTemplate>

<ControlStyle Width="5px"></ControlStyle>

            </asp:TemplateField>
            <asp:TemplateField HeaderText="Region" ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="LblRegion" runat="server" Text='<%# bind("Region")%>'></asp:Label>
                </ItemTemplate>

<ControlStyle Width="5px"></ControlStyle>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Postal Code" ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="LblPostalCode" runat="server" Text='<%# bind("PostalCode")%>'></asp:Label>
                </ItemTemplate>

<ControlStyle Width="5px"></ControlStyle>
           </asp:TemplateField>
           
            <asp:TemplateField HeaderText="Country" ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="LblCountry" runat="server" Text='<%# bind("Country")%>'></asp:Label>
                </ItemTemplate>

<ControlStyle Width="5px"></ControlStyle>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Phone" ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="LblPhone" runat="server" Text='<%# bind("Phone")%>'></asp:Label>
                </ItemTemplate>

<ControlStyle Width="5px"></ControlStyle>
           </asp:TemplateField>
           
            <asp:TemplateField HeaderText="Fax" ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="LblFax" runat="server" Text='<%# bind("Fax")%>'></asp:Label>
                </ItemTemplate>

<ControlStyle Width="5px"></ControlStyle>
            </asp:TemplateField>
        
            <asp:TemplateField HeaderText="Edit" ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:LinkButton ID="LnkEdit" runat="server" CommandName="Edit" onclick="LnkEdit_Click" 
                       >Edit</asp:LinkButton>
                </ItemTemplate>

<ControlStyle Width="5px"></ControlStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Delete" ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:LinkButton ID="LnkDelete" runat="server" CommandName="Delete"                     
                        
                        OnClientClick='return confirm("Are you sure you want to delete this entry?");' 
                        onclick="LnkDelete_Click">Delete</asp:LinkButton>
                </ItemTemplate>

<ControlStyle Width="5px"></ControlStyle>
            </asp:TemplateField>
                     
       </Columns>
    
       
<HeaderStyle BackColor="ActiveCaptionText" Font-Bold="True" Font-Size="Larger" ForeColor="CadetBlue"></HeaderStyle>

<AlternatingRowStyle BackColor="ActiveCaptionText" BorderStyle="Solid" Font-Bold="True" Font-Names="Times New Roman,Times,serif" ForeColor="CadetBlue"></AlternatingRowStyle>
     
    </asp:GridView>
    
    </div>
    </form>
</body>
</html>
