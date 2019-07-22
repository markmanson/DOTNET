<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delete_EmployeeTerritories.aspx.cs" Inherits="ADO_Day5_9.Delete_EmployeeTerritories" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delete_EmployeeTerritories</title>
    
    <script type="text/javascript">
        var TotalChkBx;
        var Counter;

        window.onload = function ()
         {
            //Get total no. of CheckBoxes in side the GridView.
             TotalChkBx = parseInt('<%= this.gvEmployeeTerritory.Rows.Count %>');

            //Get total no. of checked CheckBoxes in side the GridView.
            Counter = 0;
        }

        function HeaderClick(CheckBox)
         {
            //Get target base & child control.
             var TargetBaseControl = document.getElementById('<%= this.gvEmployeeTerritory.ClientID %>');
             var TargetChildControl = "CbxDelete";

            //Get all the control of the type INPUT in the base control.
            var Inputs = TargetBaseControl.getElementsByTagName("input");

            //Checked/Unchecked all the checkBoxes in side the GridView.
            for (var n = 0; n < Inputs.length; ++n)
                if (Inputs[n].type == 'checkbox' &&
                Inputs[n].id.indexOf(TargetChildControl, 0) >= 0)
                    Inputs[n].checked = CheckBox.checked;

            //Reset Counter
            Counter = CheckBox.checked ? TotalChkBx : 0;
        }

        function ChildClick(CheckBox, HCheckBox) {
            //get target control.
            var HeaderCheckBox = document.getElementById(HCheckBox);

            //Modifiy Counter; 
            if (CheckBox.checked && Counter < TotalChkBx)
                Counter++;
            else if (Counter > 0)
                Counter--;

            //Change state of the header CheckBox.
            if (Counter < TotalChkBx)
                HeaderCheckBox.checked = false;
            else if (Counter == TotalChkBx)
                HeaderCheckBox.checked = true;
        }
</script>

  
    <style type="text/css">
        #LblHDeleteEmployee
        {
            font-weight: 700;
        }
    </style>

  
</head>
<body>
    <form id="form1" runat="server">    
    <div align="center">
    
        <asp:GridView ID="gvEmployeeTerritory" runat="server" AllowPaging="True" Width="40%" 
            AutoGenerateColumns="False" 
            CaptionAlign="Top"
            DataKeyNames="EmployeeID,TerritoryID"
            Caption='<h2>Employees Territories</h2>'             
            onpageindexchanging="gvEmployeeTerritory_PageIndexChanging" 
            onrowcancelingedit="gvEmployeeTerritory_RowCancelingEdit" 
            onrowediting="gvEmployeeTerritory_RowEditing" 
            onrowupdating="gvEmployeeTerritory_RowUpdating" ShowFooter="True" 
            BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
            CellPadding="3" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#DCDCDC" />
        <Columns>

                <asp:TemplateField HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" HeaderStyle-Width="85px">
                    <HeaderTemplate>
                        <asp:CheckBox runat="server" ID="CbxDelete_Header" Text="DELETE" onclick="HeaderClick(this);"/>                    
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:CheckBox runat="server" ID="CbxDelete" onclick="ChildClick(this,'{0}');"/>                        
                    </ItemTemplate>
                        
                </asp:TemplateField>
                <asp:TemplateField HeaderText="EDIT" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                        <asp:LinkButton runat="server" ID="LBtnEdit" CausesValidation="true" CommandName="Edit" Text="EDIT"></asp:LinkButton>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:LinkButton runat="server" ID="LBtnUpdate" CausesValidation="true" CommandName="Update" Text="Update"></asp:LinkButton>                    
                        <asp:LinkButton runat="server" ID="LBtnCancel" CausesValidation="false" CommandName="Cancel" Text="Cancel"></asp:LinkButton>
                    </EditItemTemplate>                                
                    <FooterTemplate>
                        <asp:Button runat="server" ID="LBtnADD" CausesValidation="true" CommandName="Footer" Text="ADD" OnClick="ADD" Font-Bold="True"></asp:Button>                    
                    </FooterTemplate>
                    
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>

<ItemStyle HorizontalAlign="Left"></ItemStyle>
                 </asp:TemplateField>                
                <asp:TemplateField HeaderText="EmployeeID" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                     <asp:Label runat="server" ID="LblEmployeeID" Text='<%#DataBinder.Eval(Container.DataItem,"EmployeeID") %>'></asp:Label>                     
                    </ItemTemplate>
                    <EditItemTemplate>
                    <asp:TextBox runat="server" ID="TxtEmployeeID" MaxLength="6" Text='<%#DataBinder.Eval(Container.DataItem,"EmployeeID") %>'></asp:TextBox>                    
                    <asp:RequiredFieldValidator ID="rfvEmployeeID" runat="server" 
                        ErrorMessage="Enter EmployeeID" ControlToValidate="TxtEmployeeID" 
                        ForeColor="Red"></asp:RequiredFieldValidator>                    
                    <asp:RegularExpressionValidator ID="RgxvEmployeeID" runat="server" 
                        ControlToValidate="TxtEmployeeID" ErrorMessage="Invalid EmployeeID" ForeColor="Red" 
                        SetFocusOnError="false" ValidationExpression="^[0-9]+$"></asp:RegularExpressionValidator>                    
                    </EditItemTemplate>
                    <FooterTemplate>
                    <asp:TextBox runat="server" ID="TxtEmployeeID1" MaxLength="6" Text='<%#DataBinder.Eval(Container.DataItem,"EmployeeID") %>'></asp:TextBox>                    
                     <asp:RegularExpressionValidator ID="RgxvEmployeeID" runat="server" 
                        ControlToValidate="TxtEmployeeID1" ErrorMessage="Invalid EmployeeID" ForeColor="Red" 
                        SetFocusOnError="false" ValidationExpression="^[0-9]+$"></asp:RegularExpressionValidator>
                    
                    </FooterTemplate>
                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>

                <ItemStyle HorizontalAlign="Left"></ItemStyle>
                </asp:TemplateField>           
                <asp:TemplateField HeaderText="TerritoryID" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                     <asp:Label runat="server" ID="LblTerritoryID" Text='<%#DataBinder.Eval(Container.DataItem,"TerritoryID") %>'></asp:Label>                     
                    </ItemTemplate>
                    <EditItemTemplate>
                    <asp:TextBox runat="server" ID="TxtTerritoryID" MaxLength="6" Text='<%#DataBinder.Eval(Container.DataItem,"TerritoryID") %>'></asp:TextBox>                                        
                    <asp:RequiredFieldValidator ID="rfvTerritoryID" runat="server" 
                        ErrorMessage="Enter TerritoryID" ControlToValidate="TxtTerritoryID" 
                        ForeColor="Red"></asp:RequiredFieldValidator>                    
                    <asp:RegularExpressionValidator ID="RgxvTerritoryID" runat="server" 
                        ControlToValidate="TxtTerritoryID" ErrorMessage="Invalid TerritoryID" ForeColor="Red" 
                        SetFocusOnError="false" ValidationExpression="^[0-9]+$"></asp:RegularExpressionValidator>                    
                    
                    </EditItemTemplate>
                    <FooterTemplate>
                    <asp:TextBox runat="server" ID="TxtTerritoryID1" MaxLength="6" Text='<%#DataBinder.Eval(Container.DataItem,"TerritoryID") %>'></asp:TextBox>                    
                    <asp:RegularExpressionValidator ID="RgxvTerritoryID1" runat="server" 
                        ControlToValidate="TxtTerritoryID1" ErrorMessage="Invalid TerritoryID" ForeColor="Red" 
                        SetFocusOnError="false" ValidationExpression="^[0-9]+$"></asp:RegularExpressionValidator>                    
                    
                    </FooterTemplate>
                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>

                <ItemStyle HorizontalAlign="Left"></ItemStyle>
                </asp:TemplateField>
           </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView> 
                               
    </div>
    <div style="margin-left: 405px">
        <asp:Button runat="server" ID="LBtnDelete"
            CausesValidation="true" CommandName="Delete" Text="DELETE SELECTED" 
            OnClientClick = "return confirm('Are You Sure about Delete???');" 
            onclick="LBtnDelete_Click" style="font-weight: 700"></asp:Button><br />
            <asp:Label ID="LblDeleteEmp" runat="server" ForeColor="Green" Visible="False" Text="Information Deleted"></asp:Label>
            <asp:Label ID="LblMandatoryField" runat="server" ForeColor="Red" Visible="False" Text="*Mandatory Fields:EmployeeID & TerritoryID"></asp:Label>    
    </div>
    </form>
</body>
</html>
