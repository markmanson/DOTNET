<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeTerritories.aspx.cs" Inherits="ExerciseProject.DAY2.EmployeeTerritories" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>DAY2-3(EmployeeTerritories Page)</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:GridView ID="GrdEmpTerritories" BorderStyle="Solid"  Font-Bold="true"
            AlternatingRowStyle-Font-Bold="true"
            HeaderStyle-BackColor="ActiveCaptionText" 
            AlternatingRowStyle-BorderStyle="Solid" 
            AlternatingRowStyle-ForeColor="CadetBlue" 
            HeaderStyle-Font-Bold="true" 
            HeaderStyle-Font-Size="Larger" 
            HeaderStyle-ForeColor="CadetBlue" 
            AlternatingRowStyle-Font-Names="Times New Roman, Times, serif"
            AlternatingRowStyle-BackColor="ActiveCaptionText"  
            GridLines="Both" 
            BackColor="Azure"     
            runat="server" 
            Width="22%" AutoGenerateColumns="False">
            <Columns>
            <asp:TemplateField HeaderText="Employee ID" ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="LblEmpID" runat="server" Text='<%# bind("EmployeeID")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>       
        
            <asp:TemplateField HeaderText="Territory ID"  ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="lblTerritoryID" runat="server" Text='<%# bind("TerritoryID")%>'></asp:Label>
                </ItemTemplate>

<ControlStyle Width="5px"></ControlStyle>
            </asp:TemplateField>
           </Columns>

<HeaderStyle BackColor="ActiveCaptionText" Font-Bold="True" Font-Size="Larger" ForeColor="CadetBlue"></HeaderStyle>

<AlternatingRowStyle BackColor="ActiveCaptionText" BorderStyle="Solid" Font-Bold="True" Font-Names="Times New Roman,Times,serif" ForeColor="CadetBlue"></AlternatingRowStyle>
          </asp:GridView>
    </form>
</body>
</html>
