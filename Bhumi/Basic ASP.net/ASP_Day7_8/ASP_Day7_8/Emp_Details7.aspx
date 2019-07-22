<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Emp_Details7.aspx.cs" Inherits="ASP_Day7_8.Emp_Details7" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Emp_Details7</title>  
    <style type="text/css">
        .t1
        {
           font-family:Times New Roman;
           background-color:#D8D8D8; 
           border:2px Solid;                  
        }
        .th1
        {
            background-color:Teal;
            height:50px;
            font-size:larger;
        }
        .th2
        {
            background-color:#FFB6C1;
            height:50px;
            font-size:larger;
        }        
    </style>  
</head>
<body>
    <form id="FrmEmp_Details7" runat="server" defaultfocus="ddlSort">
    <div align="center">  
    <h2>
        <asp:Label ID="LblSort" runat="server" Text="Sorted By" 
            style="font-weight: 700"></asp:Label> 
        <asp:DropDownList ID="ddlSort" runat="server" AppendDataBoundItems="True">
            <asp:ListItem Value="0">--SELECT--</asp:ListItem>
            <asp:ListItem Value="1">Name</asp:ListItem>
            <asp:ListItem Value="2">Address</asp:ListItem>
            <asp:ListItem Value="3">Email</asp:ListItem>
            <asp:ListItem Value="4">Salary</asp:ListItem>
        </asp:DropDownList> 
        <asp:Button ID="BtnRecords" runat="server" Text="Display Records" 
            onclick="BtnRecords_Click" />
            <asp:Label runat="server" ID="LblEmpty" Visible="false" Text="NO Records Found"></asp:Label>
        </h2>               
        <asp:Repeater ID="RptEmpDetails" runat="server">
        <HeaderTemplate>        
        <table cellpadding="5" cellspacing="5" width="500px" style="font-family:Times New Roman;border-collapse:collapse;background-color:#D8D8D8" border="2px">
        <caption><h2 style="color:Navy;margin-left:-250px">Sorted Result In Repeater</h2></caption>
            <tr align="left" class="th1">
            <th>Name</th>
            <th>Address</th>
            <th>Email ID</th>
            <th>Salary</th>
            </tr>
        </HeaderTemplate>
        <ItemTemplate>
        <tr>
        <td><asp:Label runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"Name") %>' ID="LblEmpID"></asp:Label></td>
        <td><asp:Label runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"Address") %>' ID="LblAddress"></asp:Label></td>
        <td><asp:Label runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"Email") %>' ID="LblEmail"></asp:Label></td>
        <td><asp:Label runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"Salary") %>' ID="LblSalary"></asp:Label></td>        
        </tr>                            
        </ItemTemplate>         
        </asp:Repeater>                             
        <asp:DataList ID="DlEmpDetails" runat="server">
        <HeaderTemplate>
        <table cellpadding="2" cellspacing="2" width="500px" class="t1">                        
            <caption><h2 style="color:Navy;margin-left:-250px">Sorted Result In Datalist</h2></caption>
            <tr align="left" class="th2">
            <th>Name</th>
            <th>Address</th>
            <th>Email ID</th>
            <th>Salary</th>
            </tr>
        </HeaderTemplate>
        <ItemTemplate>
        <tr>
        <td><asp:Label runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"Name") %>' ID="LblEmpID"></asp:Label></td>
        <td><asp:Label runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"Address") %>' ID="LblAddress"></asp:Label></td>
        <td><asp:Label runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"Email") %>' ID="LblEmail"></asp:Label></td>
        <td><asp:Label runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"Salary") %>' ID="LblSalary"></asp:Label></td>        
        </tr>                    
        </ItemTemplate>                                     
        </asp:DataList>   
        <tr>
            <td>
                <br />
                <asp:Label ID="LblPage" runat="server" style="font-weight: 700" Text="Page:"></asp:Label>                
                <asp:Label ID="LblCurrent" runat="server" style="font-weight: 700"></asp:Label>
                <asp:Label ID="LblOf" runat="server" Text="Of"></asp:Label>
                <asp:Label ID="LblTotal" runat="server" style="font-weight: 700"></asp:Label>
                <asp:LinkButton runat="server" ID="LBtnNext" Text="Next>>"
                onclick="LBtnNext_Click" Visible="False"></asp:LinkButton>
                &nbsp;&nbsp;&nbsp;&nbsp;<asp:LinkButton runat="server" ID="LBtnPre" Text="Pre<<" 
                onclick="LBtnPre_Click" Visible="False"></asp:LinkButton>
            </td>
        </tr>
        </div>         
    </form>
</body>
</html>
