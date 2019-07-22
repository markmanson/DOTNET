<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControlButton.ascx.cs" Inherits="Day1_2.WebUserControl1" %>
<asp:Button ID="btnUp" Text="Up"
 runat="server" onclick="btnUp_Click" />
<asp:Button ID="btnDown" Text="Down" runat="server" onclick="btnDown_Click" /><br/>
<asp:Label ID="lblNot" Visible="false" runat="server" BackColor="Red" ForeColor ="Black"></asp:Label><br/>

