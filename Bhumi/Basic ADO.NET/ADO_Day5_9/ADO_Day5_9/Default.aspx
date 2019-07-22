<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ADO_Day5_9.Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Default</title> 
 <script runat="server">
     void cvTitleOfCourtesy_ServerValidate(object sender, ServerValidateEventArgs e)
     {
         if (e.Value == "Mr.")
             e.IsValid = true;
         else if (e.Value == "Mrs.")
             e.IsValid = true;
         else if (e.Value == "Ms.")
             e.IsValid = true;
         else
             e.IsValid = false;
     }     
 </script>
 <script type="text/javascript">
     function cvTitleOfCourtesy_ClientValidate(source, arguments)
      {
         if (arguments.Value == "Mr." || arguments.Value == "Mrs." || arguments.Value == "Ms.")
             arguments.IsValid = true;
         else
             arguments.IsValid = false;
     }
 </script>  
 <script type="text/javascript">

     function checkDate(sender, args)
      {
          if (sender._selectedDate > new Date()) 
         {
             alert("You cannot select a Future Date!");
             sender._selectedDate = new Date();
             // set the date back to the current date
             sender._textbox.set_Value(sender._selectedDate.format(sender._format))
         }
     }
    </script>
  
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div align="center">    
    <asp:GridView ID="gvEmployees" runat="server" AllowPaging="True"
            AutoGenerateColumns="False" 
            onpageindexchanging="gvEmployees_PageIndexChanging"             
            CaptionAlign="Top"            
            Caption='<h3><table border="1" width="40%"><tr><td align="center">Employee Details</td></tr></table></h3>' 
            PageSize="5" onrowcancelingedit="gvEmployees_RowCancelingEdit" DataKeyNames="EmployeeID"
            onrowdeleting="gvEmployees_RowDeleting" 
            onrowediting="gvEmployees_RowEditing" onrowupdating="gvEmployees_RowUpdating" 
            CellPadding="4" ForeColor="#333333" 
            GridLines="None" Height="226px" Width="80%">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:TemplateField>
                <EditItemTemplate>
                    <asp:LinkButton runat="server" ID="LBtnUpdate" CausesValidation="true" CommandName="Update" Text="Update"></asp:LinkButton>
                    <asp:LinkButton runat="server" ID="LBtnCancel" CausesValidation="false" CommandName="Cancel" Text="Cancel"></asp:LinkButton>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:LinkButton runat="server" ID="LBtnEdit" CausesValidation="true" CommandName="Edit" Text="EDIT"></asp:LinkButton>
                    <asp:LinkButton runat="server" ID="LBtnDelete" CausesValidation="true" CommandName="Delete" Text="DELETE" OnClientClick = "return confirm('You Want to Delete Details Of this Employee???');"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="EmployeeID" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                    <asp:Label runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"EmployeeID") %>' ID="LblHEmpID"></asp:Label>                        
                    </ItemTemplate>                    

        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>

            </asp:TemplateField> 
            <asp:TemplateField HeaderText="Salutation" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                    <asp:Label runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"TitleOfCourtesy") %>' ID="LblTitleOfCourtesy" Enabled="false"></asp:Label>                        
                    </ItemTemplate> 
                    <EditItemTemplate>
                    <asp:TextBox runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"TitleOfCourtesy") %>' ID="TxtTitleOfCourtesy1" Enabled="true"></asp:TextBox>
                    <asp:CustomValidator runat="server" ID="cvTitleOfCourtesy" ControlToValidate="TxtTitleOfCourtesy1" OnServerValidate="cvTitleOfCourtesy_ServerValidate" ErrorMessage="Enter 'Mr.''Ms.''Mrs.'/" ForeColor="Red" SetFocusOnError="True" ClientValidationFunction="cvTitleOfCourtesy_ClientValidate" />                    
                    </EditItemTemplate>                   

        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>

           </asp:TemplateField>
            <asp:TemplateField HeaderText="First Name" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                    <asp:Label runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"FirstName") %>' ID="LblFirstName" Enabled="false"></asp:Label>                        
                    </ItemTemplate> 
                    <EditItemTemplate>
                    <asp:TextBox runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"FirstName") %>' ID="TxtFirstName1" Enabled="true"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvFirstname" runat="server" 
                        ErrorMessage="Enter FirstName" ControlToValidate="TxtFirstName1" 
                        ForeColor="Red"></asp:RequiredFieldValidator>                    
                    </EditItemTemplate>                   

        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>

           </asp:TemplateField> 
            <asp:TemplateField HeaderText="Last Name" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                    <asp:Label runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"LastName") %>' ID="LblLastName" Enabled="false"></asp:Label>                        
                    </ItemTemplate>
                    <EditItemTemplate>
                    <asp:TextBox runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"LastName") %>' ID="TxtLastName1" Enabled="true"></asp:TextBox>                                            
                    <asp:RequiredFieldValidator ID="rfvLastname" runat="server" 
                        ErrorMessage="Enter LastName" ControlToValidate="TxtLastName1" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                    </EditItemTemplate>                    

        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>

           </asp:TemplateField>
            <asp:TemplateField HeaderText="BirthDate" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                    <asp:Label runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"BirthDate") %>' ID="LblBirthDate" Enabled="false"></asp:Label>                        
                    </ItemTemplate>
                    <EditItemTemplate>
                    <asp:TextBox runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"BirthDate") %>' ID="TxtBirthDate1" Enabled="true"></asp:TextBox>
                        <asp:CalendarExtender ID="CalendarExtender1" runat="server" Format="MM/dd/yyyy" OnClientDateSelectionChanged="checkDate" TargetControlID="TxtBirthDate1">
                        </asp:CalendarExtender>
                     </EditItemTemplate>                    

        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>

            </asp:TemplateField> 
            <asp:TemplateField HeaderText="City" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                    <asp:Label runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"City") %>' ID="LblCity" Enabled="false"></asp:Label>                        
                    </ItemTemplate> 
                    <EditItemTemplate>
                    <asp:TextBox runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"City") %>' ID="TxtCity1" Enabled="true"></asp:TextBox>
                    </EditItemTemplate>                   

        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>

            </asp:TemplateField>
            <asp:TemplateField HeaderText="Country" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                    <asp:Label runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"Country") %>' ID="LblCountry" Enabled="false"></asp:Label>                        
                    </ItemTemplate>
                    <EditItemTemplate>
                    <asp:TextBox runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"Country") %>' ID="TxtCountry1" Enabled="true"></asp:TextBox>
                    </EditItemTemplate>                    

        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>

            </asp:TemplateField> 
            <asp:TemplateField HeaderText="Phone No." HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                    <asp:Label runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"HomePhone") %>' ID="LblHomePhone" Enabled="false"></asp:Label>                        
                    </ItemTemplate> 
                    <EditItemTemplate>
                    <asp:TextBox runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"HomePhone") %>' ID="TxtHomePhone1" Enabled="true"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RgxvPhoneNo" runat="server" 
                    ControlToValidate="TxtHomePhone1" ErrorMessage="Enter PhoneNo in Proper format" ForeColor="Red" 
                    SetFocusOnError="True" ValidationExpression="^(\([0-9]|[0-9])(\d{2}|\d{2}\))(-|.|\s)?\d{3}(-|.|\s)?\d{4}$"></asp:RegularExpressionValidator>
                    </EditItemTemplate>                   

        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>

            </asp:TemplateField>                      
        </Columns>    
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <asp:LinkButton runat="server" ID="LBtnAddNew" Text="ADD NEW Employee" 
            PostBackUrl="~/Add_Employee.aspx" Font-Size="Larger"></asp:LinkButton><br />
            <asp:Label runat="server" ID="LblHDeleteEmployee" Visible="False" ForeColor="Green" 
            style="font-weight: 700">Employee Details Deleted.</asp:Label>    
    </div>
    </form>
</body>
</html>
