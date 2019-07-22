<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThreeEmployees.aspx.cs" Inherits="Day_5_9.Last" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>AddEmployees</title>
</head>

    <body style="background-color: Gray" >
<script language="javascript" type ="text/javascript">
function Confrimdelete()
{
        if(confirm("R u sure u want to delete this selected value?")== true)
        {       
          document.getElementById("Button1").click();
        }
  
}
 function validateCheckBoxes() 
 {
        var isValid = false;
        var gridView = document.getElementById('<%= gvEmpT.ClientID %>');
        for (var i = 1; i < gridView.rows.length; i++) 
        {
            var inputs = gridView.rows[i].getElementsByTagName('input');
                if (inputs != null) 
                {
                    if (inputs[0].type == "checkbox") 
                       {
                           if (inputs[0].checked) 
                              {
                                     isValid = true;                              
                                       // return true;                                     
                               }
                       }
                 }
         }
         if(isValid ==false )
         {
            alert("Please select atleast one checkbox");
            return false;
         }
         else if (isValid ==true )
         {
            if(confirm("R u sure u want to delete this selected value?")==true )
            {
            return true ;
            }
            else
            {
            return false ;
            }
         }
}
 
 
</script>
    <form id="form1" runat="server">
    <div>
    
       <asp:Label ID="lblError" runat="server" Text=""  Font-Bold="True" Font-Italic="True" 
            ForeColor="#990099"></asp:Label>
        <asp:Panel ID="Pan1" runat="server" Height="555px" ScrollBars="Auto">
  <asp:LinkButton ID="lbtnAdd" runat="server"  Font-Bold="True" onclick="lbtnAdd_Click" >Add Employee Details</asp:LinkButton> 
        &nbsp;  
            <asp:GridView ID="gvEmpT" runat="server" BackColor="#DEBA84" DataKeyNames="EmployeeId"
                BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
                CellPadding="3" AutoGenerateColumns="False" 
                ondatabound="gvEmpT_DataBound" onrowdatabound="gvEmpT_RowDataBound" 
                CellSpacing="2" >
                
              <%--  OnRowDeleting="gvEmpT_RowDeleting"
                OnRowCancelingEdit="gvEmpT_RowCancelingEdit" OnRowDataBound="gvEmpT_RowDataBound"--%>
                
                
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <Columns>
                    <asp:TemplateField HeaderText="Delete">
                        <HeaderTemplate>
                            <asp:CheckBox ID="chkHeader" runat="server" AutoPostBack="true" 
                                oncheckedchanged="chkHeader_CheckedChanged" />
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:CheckBox ID="chkItem" runat="server" AutoPostBack="true" 
                                oncheckedchanged="chkItem_CheckedChanged" />
                            <%-- <asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete"
                                Text="Delete" OnClientClick="return confirm('Are you want to delete this Employee Details ?');">
                            </asp:LinkButton>--%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Edit">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Edit</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <%--
                <asp:BoundField DataField = "EmployeeID" HeaderText = "Employee ID" 
                      ReadOnly = "false" />--%>
                    <asp:BoundField DataField="EmployeeId" HeaderText="id" ReadOnly="false" />
                    <asp:BoundField DataField="FirstName" HeaderText="Name" ReadOnly="false" />
                    <asp:BoundField DataField="LastName" HeaderText="id" ReadOnly="false" 
                        Visible="false" />
                    <asp:BoundField DataField="Title" HeaderText="Tittle" ReadOnly="false" />
                    <asp:BoundField DataField="TitleOfCourtesy" HeaderText="Title Of Courtesy" 
                        ReadOnly="false" Visible="false" />
                    <asp:BoundField DataField="BirthDate" HeaderText="Birth Date" 
                        ReadOnly="false" />
                    <asp:BoundField DataField="HireDate" HeaderText="Hire Date" ReadOnly="false" />
                    <asp:BoundField DataField="Address" HeaderText="Address" ReadOnly="false" />
                    <asp:BoundField DataField="City" HeaderText="City" ReadOnly="false" />
                    <asp:BoundField DataField="Region" HeaderText="Region" ReadOnly="false" />
                    <asp:BoundField DataField="PostalCode" HeaderText="PostalCode" 
                        ReadOnly="false" />
                    <asp:BoundField DataField="Country" HeaderText="Country" ReadOnly="false" />
                    <asp:BoundField DataField="HomePhone" HeaderText="HomePhone" ReadOnly="false" />
                    <asp:BoundField DataField="Extension" HeaderText="Extension" ReadOnly="false" />
                    <asp:TemplateField HeaderText="Notes">
                        <ItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" ReadOnly="true" 
                                Text='<%#Eval("Notes")%>' TextMode="MultiLine"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="ReportsTo" HeaderText="ReportsTo" ReadOnly="false" />
                    <%--  <asp:BoundField DataField="PhotoPath" HeaderText="PhotoPath" ReadOnly="false" />--%>
                    <%--      <asp:BoundField DataField = "EmployeeTerritories.TerritoryID" HeaderText = "Territory ID" 
                      ReadOnly = "false" />
                      
                <asp:BoundField DataField = "Territories.TerritoryDescription" HeaderText = "Description"  ReadOnly = "false" />--%>
                    <asp:TemplateField HeaderText="Description">
                        <ItemTemplate>
                            <asp:ListBox ID="ListBox1" runat="server" DataTextField="territoryDescription" 
                                SelectionMode="Multiple"></asp:ListBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                
            </asp:GridView>
          <%-- <asp:Button ID="Button1" runat="server" Text="Delete" onclick="Button1_Click"  OnClientClick="return confirm('Are you want to delete this Employee Details ?');"/>--%>
           <asp:Button ID="Button1" runat="server" Text="Delete" onclick="Button1_Click"  OnClientClick="return validateCheckBoxes();"/>
            <asp:Label ID="lblError1" runat="server" Visible ="False" Font-Bold="True" 
                ForeColor="Red"></asp:Label>
        </asp:Panel>
    
    
    </div>
    </form>
</body>
</html>
