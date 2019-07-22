<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Repeater.aspx.cs" Inherits="Day7_8.Repeater" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>By Repeater</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    </div>
    <asp:Table ID="Table1" runat="server" HorizontalAlign="Center">
    <asp:TableRow runat="server">
    <asp:TableCell> 
        <asp:Label ID="lblBy" runat="server" Text="Sorted By"></asp:Label>   
        <asp:DropDownList ID="ddlSort" runat="server" >
            <asp:ListItem Text="None" Value="None"></asp:ListItem>
            <asp:ListItem Text="Name" Value="Ename"></asp:ListItem>
            <asp:ListItem Text="Address" Value="Address"></asp:ListItem>
            <asp:ListItem Text="Salary" Value="Salary"></asp:ListItem>
        </asp:DropDownList>
        </asp:TableCell>
        <asp:TableCell><asp:Button ID="btnDisplay" runat="server" Text="Display Records" onclick="btnDisplay_Click" />
        </asp:TableCell>
    </asp:TableRow>
    </asp:Table>
    <asp:Table ID="tblMain" runat="server" HorizontalAlign="Center">
    <asp:TableRow><asp:TableCell>
    <asp:Repeater ID="rptEmp" runat="server" Visible="false"
    EnableViewState="False" >
    <HeaderTemplate>
        <table border="2px">
         <thead align="center">
                <asp:Label ID="lblHeadTbl" Text="Employee's Details Reapter" runat="server" Font-Bold="true" ForeColor="ButtonShadow">
         </asp:Label>
         </thead> 
         <tr>
            <td align="center">Name</td>
            <td align="center">Email</td>
            <td align="center">Address</td>
            <td align="center">Salary</td>
         </tr>
    </HeaderTemplate>
    <ItemTemplate>
               <tr> 
                <td align="center"><%# Eval("Ename") %></td>
                <td align="center"><%# Eval("Email") %></td>
                <td align="center"><%# Eval("Address") %></td>
                <td align="center"><%# Eval("Salary") %></td>
               </tr>
    </ItemTemplate>
    <FooterTemplate>
        </table>
    </FooterTemplate>
</asp:Repeater>
            <asp:Repeater ID="rptPages" runat="server" onitemcommand="rptPages_ItemCommand" Visible="false">	            
	            <ItemTemplate>
	                <asp:LinkButton ID="btnPage"
	                 style="padding:1px 3px; margin:1px; background:#ccc; border:solid 1px #666; font:8pt tahoma;"
	                 CommandName="Page" CommandArgument="<%# Container.DataItem %>"
	                 runat="server"><%# Container.DataItem %>
	                </asp:LinkButton>
	            </ItemTemplate>
	        </asp:Repeater>
	        </asp:TableCell><asp:TableCell>
                <asp:DataList ID="dtEmp" runat="server" Visible="false">
                <HeaderTemplate>
                <table border="2px"> 
                <thead align="center">
                     <asp:Label ID="lblHeadDL" Text="Employee's Details Datalist" runat="server" Font-Bold="true" ForeColor="ButtonShadow"></asp:Label>
	            </thead>
	                    <tr>
                            <td align="center">Name</td>
                            <td align="center">Email</td>
                            <td align="center">Address</td>
                            <td align="center">Salary</td>
                        </tr>
                </HeaderTemplate>
                    <ItemTemplate>
                        <tr> 
                            <td align="center"><%# Eval("Ename") %></td>
                            <td align="center"><%# Eval("Email") %></td>
                            <td align="center"><%# Eval("Address") %></td>
                            <td align="center"><%# Eval("Salary") %></td>
                       </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                            </table>
                    </FooterTemplate>
                </asp:DataList>
	        </asp:TableCell></asp:TableRow>
	        <asp:TableRow><asp:TableCell ColumnSpan="2">
	                    <asp:Label ID="lblCrnt" runat="server" Visible="false" Font-Italic="true" ForeColor="ButtonShadow"></asp:Label>
	        </asp:TableCell></asp:TableRow>
	        <asp:TableFooterRow>
	        <asp:TableCell>
	            <asp:Button ID="btnFrst" runat="server" Text="First" Visible="false" onclick="btnFrst_Click" />
	            <asp:Button ID="btnPrev" runat="server" Text="Prev" Visible="false" onclick="btnPrev_Click" />	            
	            <asp:Button ID="btnNext" runat="server" Text="Next" Visible="false" onclick="btnNext_Click" />
	            <asp:Button ID="btnLast" runat="server" Text="Last" Visible="false" onclick="btnLast_Click" />
	        </asp:TableCell>
	        </asp:TableFooterRow>
	        </asp:Table>		            
	            
            
	            

    </form>
</body>
</html>
