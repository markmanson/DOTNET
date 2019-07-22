<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ApplyWebServiceInApplication._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>With Web Service</title>

    <script type="text/javascript" language="javascript">
    function EnterValue()
    {
        if(document.forms[0]["TxtValue1"].value==null || document.forms[0]["TxtValue1"].value=="" ||document.forms[0]["TxtValue2"].value==null || document.forms[0]["TxtValue2"].value=="" )
        {
        alert("Please Enter Value");
        if(document.forms[0]["TxtValue1"].value==null || document.forms[0]["TxtValue1"].value=="")
        document.forms[0]["TxtValue1"].focus();
        else
        document.forms[0]["TxtValue2"].focus();
        return false;
        }
        else
        {
        return true;
        }
    }
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div>
                <asp:Panel ID="Pnl" runat="server" Font-Size="15px">
                    <table>
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="LblValue1" Text="Value1:"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TxtValue1" runat="server" Width="169px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="LblValue2" Text="Value2:"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TxtValue2" runat="server" Width="167px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ID="LblAnswer" Text="Answer:"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="LblDisplayAnswer" Font-Bold="true" Font-Size="15px" ForeColor="BlueViolet"
                                    runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Button runat="server" ID="BtnAdd" Text="Add" OnClick="BtnAdd_Click" OnClientClick="return EnterValue();" />
                                <asp:Button runat="server" ID="BtnSubtract" Text="Subtract" OnClick="BtnSubtract_Click"
                                    OnClientClick="return EnterValue();" />
                                <asp:Button runat="server" ID="BtnMultiply" Text="Multiply" OnClick="BtnMultiply_Click"
                                    OnClientClick="return EnterValue();" />
                                <asp:Button runat="server" ID="BtnDivide" Text="Divide" OnClick="BtnDivide_Click"
                                    OnClientClick="return EnterValue();" Width="63px" />
                                <asp:Button runat="server" ID="BtnClear" Text="Clear" OnClick="BtnClear_Click" />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
                <asp:Panel ID="PnlGrid" GroupingText="Grid" Font-Size="15px" Width="50%" runat="server">
                    <asp:GridView ID="EmployeeGrid" runat="server" Width="50%" AutoGenerateColumns="false">
                        <Columns>
                            <asp:BoundField DataField="EmpName" HeaderText="Name" />
                            <asp:BoundField DataField="Address" HeaderText="Address" />
                            <asp:BoundField DataField="Email" HeaderText="Email" />
                            <asp:BoundField DataField="Salary" HeaderText="Salary" />
                        </Columns>
                    </asp:GridView>
                </asp:Panel>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>
</html>
