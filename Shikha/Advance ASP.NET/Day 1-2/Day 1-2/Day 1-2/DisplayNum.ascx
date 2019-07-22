<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DisplayNum.ascx.cs" Inherits="Day_1_2.DisplayNum" %>

<style type="text/css">
    .style1
    {
        width: 99px;
    }
</style>

<div id="DIVBtn" runat="server" style="background-color:Gray">
   
        <table align="center" border="2" style="background-color:Teal">
            <tr>
                <td class="style1">
                   <asp:Button Font-Bold="True" ID="buttonUp" runat="server"  
    Text="UP" OnClick="buttonUp_Click" BackColor="#996633" Height="32px" Width="89px" />
                </td>
                <td>
                   <asp:Button Font-Bold="True" ID="buttonDown" runat="server" 
    Text="DOWN" OnClick="buttonDown_Click" BackColor="#996633" Height="32px" 
                        style="margin-left: 18px" Width="89px" />
                </td>
            </tr>
        </table>
   
</div>
