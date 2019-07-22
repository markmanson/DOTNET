<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Emp_Details.aspx.cs" Inherits="ADO_Day2_4.Emp_Details" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type = "text/javascript">
        function Confirm() {
            var confirm_value = document.createElement("INPUT");
            confirm_value.type = "hidden";
            confirm_value.name = "confirm_value";
            if (confirm("Do you want to Delete data of This Employee?"))
            {
                confirm_value.value = "Yes";
            }
            else
            {
                confirm_value.value = "No";
            }
            document.forms[0].appendChild(confirm_value);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
   <div align="center">
    
    <asp:Label runat="server" ID="lblmessage" Text="Employee Details Deleted." 
           Visible="False" ForeColor="Blue" style="font-weight: 700; float: left"></asp:Label>
        <br />
        <asp:GridView ID="gvEmployees" runat="server" AllowPaging="True"
            AutoGenerateColumns="False" 
            onpageindexchanging="GridView1_PageIndexChanging"             
            CaptionAlign="Top"            
            Caption='<h3><table border="1" width="40%" cellpadding="0" cellspacing="0" bgcolor="yellow"><tr><td align="center">Employee Details</td></tr></table></h3>' 
            PageSize="5" onrowcancelingedit="GridView1_RowCancelingEdit" DataKeyNames="EmployeeID"
            onrowdeleting="GridView1_RowDeleting" 
            onrowediting="GridView1_RowEditing" onrowupdating="GridView1_RowUpdating" 
            Height="16px" Width="80%" CellPadding="4" ForeColor="#333333" 
            GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
                <asp:TemplateField>
                    <EditItemTemplate>
                        <asp:LinkButton ID="LnkBtnUpdate" runat="server" CausesValidation="true" CommandName="Update" Text="Update">
                        </asp:LinkButton>
                        <asp:LinkButton ID="LnkBtnCancel" runat="server" CausesValidation="false" CommandName="Cancel" Text="Cancel">
                        </asp:LinkButton>
                    </EditItemTemplate>                                                                                                                              
                   <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="true" CommandName="Edit" Text="Edit"></asp:LinkButton>                    
                        <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="true" CommandName="Delete" Text="Delete" OnClientClick = "Confirm()"></asp:LinkButton>
                    </ItemTemplate>
                    </asp:TemplateField>                              
                <asp:TemplateField HeaderText="EmployeeID" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                    <asp:Label runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"EmployeeID") %>' ID="empid" ReadOnly="true"></asp:Label>                        
                    </ItemTemplate>
                    <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                </asp:TemplateField>            
                <asp:TemplateField HeaderText="Firstname" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                    <asp:Label runat="server" Enabled="false" Text=' <%#DataBinder.Eval(Container.DataItem,"FirstName") %>' ID="fname"></asp:Label>                       
                    </ItemTemplate>
                    <EditItemTemplate>
                    <asp:TextBox runat="server" Enabled="true" Text=' <%#DataBinder.Eval(Container.DataItem,"FirstName") %>' ID="fname_Edit"></asp:TextBox> 
                    <asp:RequiredFieldValidator ID="rfvFirstname" runat="server" 
                        ErrorMessage="Enter FirstName" ControlToValidate="fname_Edit" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                    </EditItemTemplate>                    
                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                </asp:TemplateField>           
                <asp:TemplateField HeaderText="Lastname" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                    <asp:Label runat="server" Enabled="false" Text='<%#DataBinder.Eval(Container.DataItem,"LastName") %>' ID="lname"></asp:Label>                        
                    </ItemTemplate>
                    <EditItemTemplate>
                    <asp:TextBox runat="server" Enabled="true" Text='<%#DataBinder.Eval(Container.DataItem,"LastName") %>' ID="lname_Edit"></asp:TextBox>                                                                  
                    <asp:RequiredFieldValidator ID="rfvLastname" runat="server" 
                        ErrorMessage="Enter LastName" ControlToValidate="lname_Edit" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                    </EditItemTemplate>                
                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Salutation" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                    <asp:Label runat="server" Enabled="false" Text='<%#DataBinder.Eval(Container.DataItem,"TitleOfCourtesy") %>' ID="title"></asp:Label>                        
                    </ItemTemplate>
                    <EditItemTemplate>
                    <asp:TextBox runat="server" Enabled="true" Text='<%#DataBinder.Eval(Container.DataItem,"TitleOfCourtesy") %>' ID="title_Edit"></asp:TextBox>                        
                    
                    </EditItemTemplate>
                    <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="BirthDate" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                    <asp:Label runat="server" Enabled="false" Text='<%#DataBinder.Eval(Container.DataItem,"BirthDate") %>' ID="birthday"></asp:Label>                        
                    </ItemTemplate>
                    <EditItemTemplate>
                    <asp:TextBox runat="server" Enabled="true" Text='<%#DataBinder.Eval(Container.DataItem,"BirthDate") %>' ID="birthday_Edit"></asp:TextBox>                                            
                    </EditItemTemplate>
                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                </asp:TemplateField>           
                <asp:TemplateField HeaderText="Address" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" HeaderStyle-Width="14%" ItemStyle-Width="14%">
                    <ItemTemplate>
                    <asp:Label runat="server" Enabled="false" Text=' <%#DataBinder.Eval(Container.DataItem,"Address") %>' ID="address"></asp:Label>                       
                    </ItemTemplate>
                    <EditItemTemplate>
                    <asp:TextBox runat="server" Enabled="true" Text=' <%#DataBinder.Eval(Container.DataItem,"Address") %>' ID="address_Edit"></asp:TextBox>                                           
                    </EditItemTemplate>
                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                </asp:TemplateField>            
                <asp:TemplateField HeaderText="City"  HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                    <asp:Label runat="server" Enabled="false" Text='<%#DataBinder.Eval(Container.DataItem,"City") %>' ID="city"></asp:Label>                        
                    </ItemTemplate>
                    <EditItemTemplate>
                    <asp:TextBox runat="server" Enabled="true" Text='<%#DataBinder.Eval(Container.DataItem,"City") %>' ID="city_Edit"></asp:TextBox>                                            
                    </EditItemTemplate>
                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Country" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                    <asp:Label runat="server" Enabled="false" Text='<%#DataBinder.Eval(Container.DataItem,"Country") %>' ID="country"></asp:Label>                        
                    </ItemTemplate>
                    <EditItemTemplate>
                    <asp:TextBox runat="server" Enabled="true" Text='<%#DataBinder.Eval(Container.DataItem,"Country") %>' ID="country_Edit"></asp:TextBox>                                            
                    </EditItemTemplate>
                    <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="ContactNo" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                    <asp:Label runat="server" Enabled="false" Text='<%#DataBinder.Eval(Container.DataItem,"HomePhone") %>' ID="contactno"></asp:Label>                        
                    </ItemTemplate>
                    <EditItemTemplate>
                    <asp:TextBox runat="server" Enabled="true" Text='<%#DataBinder.Eval(Container.DataItem,"HomePhone") %>' ID="contactno_Edit"></asp:TextBox>                                            
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
       <asp:LinkButton runat="server" ID="add" Text="ADD NEW" 
            PostBackUrl="~/Add_Employee.aspx" Width="200px" style="font-weight: 700"></asp:LinkButton>
    </div>
    </form>
</body>
</html>
