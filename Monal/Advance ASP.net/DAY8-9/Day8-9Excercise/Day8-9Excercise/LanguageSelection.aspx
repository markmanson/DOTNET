<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LanguageSelection.aspx.cs"
    Inherits="Day8_9ExcerobjCultureInfose.LanguageSelection" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Select Language Page</title>
    <link href="Stylesheet.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="PnlLanguage" runat="server" CssClass="panelLanguage" GroupingText="Select Language">
            <asp:RadioButtonList ID="RbtnLst" runat="server" AutoPostBack="true" CssClass="lblControl">
                <asp:ListItem Text="English" Value="English.ResourceFile"></asp:ListItem>
                <asp:ListItem Text="Japanees" Value="Japanees.ResourceFile"></asp:ListItem>
            </asp:RadioButtonList>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
