<%@ Page Language="C#" MasterPageFile="~/Nested.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="Day1_2.WebForm1" Title="Untitled Page" ClassName="WebUserControlGrid" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <h1 style="font-size:xx-large; text-align:center">User Control Example</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceNested" runat="server">
    <div style="float: left; width: 200px; height: 800px;border-color:Red; border-style:solid; border-width:medium;margin-left:auto;background-color:ThreeDFace"><br /><br />
 <asp:Button ID="btnGetEmp" Text="GetEmployeeDetail" runat="server" OnClick="Getbtn_Click" Width="150" /><br /><br />
 <asp:Button ID="btnGetDetails" Text="GetDepartmentDetails" runat="server" OnClick="btnGetDetails_Click" Width="150" />
 </div> 
 <iframe runat="server" id="Frame1" style="border-color: #FF0000; width:1000px; height:800px" ></iframe>
</asp:Content>
