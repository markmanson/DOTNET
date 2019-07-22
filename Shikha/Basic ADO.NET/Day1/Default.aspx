<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Day1._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>My Web Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:GridView ID="gvS" runat="server" BorderColor="#DEDFDE" ForeColor="green" AutoGenerateColumns="false" >
     <PagerStyle ForeColor="Black" HorizontalAlign="Right" 
       BackColor="#F7F7DE"></PagerStyle>
    <HeaderStyle ForeColor="White" Font-Bold="True" 
       BackColor="#6B696B"></HeaderStyle>
       
    <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>
      <Columns>
      <asp:TemplateField HeaderText="EmployeeID"><ItemTemplate>
          <asp:Label ID="LblEmployeeID" runat="server" Text='<%# 
Bind("EmployeeID") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField HeaderText="TitleOfCourtesy" DataField="TitleOfCourtesy" 
         ></asp:BoundField>
        <asp:BoundField HeaderText="FirstName" DataField="FirstName" 
           ></asp:BoundField>
           <asp:BoundField HeaderText="LastName" DataField="LastName" 
           ></asp:BoundField>
           <asp:BoundField HeaderText="Title" DataField="Title" 
           ></asp:BoundField>
           <asp:BoundField HeaderText="BirthDate" DataField="BirthDate" 
           ></asp:BoundField>
           <asp:BoundField HeaderText="HireDate" DataField="HireDate" 
           ></asp:BoundField>
            <asp:BoundField HeaderText="Address" DataField="Address" 
           ></asp:BoundField>
            <asp:BoundField HeaderText="City" DataField="City" 
           ></asp:BoundField>
            <asp:BoundField HeaderText="Region" DataField="Region" 
           ></asp:BoundField>
        
    </Columns>
      
        </asp:GridView>
       
          



    </div>
    </form>
</body>
</html>
