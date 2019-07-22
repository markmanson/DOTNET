<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exersice07.aspx.cs" Inherits="Day_7_8.Exersice07" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Employee Record</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        </style>
    </head>
<body>
    <form id="form1" runat="server">
    <div style="width: 375px">
        <asp:Table ID="Table1" runat="server" Width="345px">
        <asp:TableRow><asp:TableCell>
   <table border="1" cellpadding="5" cellspacing="2" align="center" style="width: 374px"><tr><td>Sort By
      <asp:DropDownList ID="ddlSortBy" runat="server">
      <asp:ListItem Value="None">None</asp:ListItem>
    <asp:ListItem Value="EName">EName</asp:ListItem>
    <asp:ListItem Value="Address">Address</asp:ListItem>
    <asp:ListItem Value="Email">Email</asp:ListItem>
    <asp:ListItem Value="Salary">Salary</asp:ListItem>
</asp:DropDownList></td><td>
<asp:Button runat="server" ID="DisplayRecords" Text="DisplayRecords" onclick="DisplayRecords_Click" 
             /></td></tr>
    <asp:Repeater ID="rptEmp"  runat="server" Visible="false" >
        <HeaderTemplate>
      <thead align="center">
                     <asp:Label ID="lblHeadRP" Text="Employee's Details Repeaters" runat="server" Font-Bold="true" ForeColor="ButtonShadow"></asp:Label>
	            </thead>
        <tr bgcolor="gray">
        <td><b>EName</b>
        </td>
        <td><b>Address</b></td> 
        <td><b>Email</b></td>
         <td><b>Salary</b></td>
        </tr>
        </HeaderTemplate>
         <ItemTemplate>
         <tr>
         <td>
        <%# Eval("EName") %>
         </td>
             <td>
        <%# Eval("Address")%> 
             </td>
             <td>
         <%# Eval("Email") %>   
             </td>
             <td>
         <%# Eval("Salary")%>    
             </td>
             </tr>
         </ItemTemplate> 
        <AlternatingItemTemplate >
         <tr bgcolor="aqua" >
         <td>
         <%#DataBinder.Eval(Container.DataItem, "EName")%>
         </td>
             <td>
         <%#DataBinder.Eval(Container.DataItem, "Address")%>    
             </td>
              <td>
         <%#DataBinder.Eval(Container.DataItem, "Email")%>    
             </td>
               <td>
         <%#DataBinder.Eval(Container.DataItem, "Salary")%>    
             </td>
         </tr>
         </AlternatingItemTemplate>
         
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
          </table>  <table align="center"><tr><td>
          <asp:Label id="lblCurrentPage" runat="server" />
           <asp:LinkButton id="lnkFirst" runat="server" text=" First " OnClick="lnkFirst_Click" />
        <asp:LinkButton id="lnkPrev" runat="server" text=" Previous " OnClick="lnkPrev_Click" />
<asp:LinkButton id="lnkNext" runat="server" text=" Next " OnClick="lnkNext_Click" />
<asp:LinkButton id="lnkLast" runat="server" text=" Last " OnClick="lnkLast_Click" />
 
    </td> </tr> </table>
          </asp:TableCell>
          <asp:TableCell>
          <table border="1" cellpadding="5" cellspacing="2" align="center" style="width: 374px">
              <tr>
                  <td> <asp:DataList ID="dtEmp" runat="server" Visible="false">
        <HeaderTemplate>
       <thead align="center">
                     <asp:Label ID="lblHeadDL" Text="Employee's Details Datalist" runat="server" Font-Bold="true" ForeColor="ButtonShadow"></asp:Label>
	            </thead>
        <tr bgcolor="gray">
        <td><b>EName</b>
        </td>
        <td><b>Address</b></td> 
        <td><b>Email</b></td>
         <td><b>Salary</b></td>
        </tr>
        </HeaderTemplate>
         <ItemTemplate>
         <tr>
         <td>
        <%# Eval("EName") %>
         </td>
             <td>
        <%# Eval("Address")%> 
             </td>
             <td>
         <%# Eval("Email") %>   
             </td>
             <td>
         <%# Eval("Salary")%>    
             </td>
             </tr>
         </ItemTemplate> 
        <AlternatingItemTemplate >
         <tr bgcolor="aqua" >
         <td>
         <%#DataBinder.Eval(Container.DataItem, "EName")%>
         </td>
             <td>
         <%#DataBinder.Eval(Container.DataItem, "Address")%>    
             </td>
              <td>
         <%#DataBinder.Eval(Container.DataItem, "Email")%>    
             </td>
               <td>
         <%#DataBinder.Eval(Container.DataItem, "Salary")%>    
             </td>
         </tr>
         </AlternatingItemTemplate>
         
          </asp:DataList>
                      </td>
              </tr>
          </table>
       
    
        </asp:TableCell> </asp:TableRow> 
     </asp:Table>    
    </div>
    </form>
</body>
</html>
