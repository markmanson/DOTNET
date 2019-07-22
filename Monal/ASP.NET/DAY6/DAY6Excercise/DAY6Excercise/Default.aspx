<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DAY6Excercise._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Select Checkbox</title>
    <link href="Stylesheet.css" rel="Stylesheet" type="text/css" />

    <script type="text/javascript" language="javascript">
    function SelectCheckBoxList()
    {
          var cnt=0;
          var value=document.getElementById('ChkLstValue');
          var Name=value.getElementsByTagName('input');
          for (i=0;i<Name.length;i++) 
          {
                if (Name[i].type == "checkbox") 
               {
                    if(Name[i].checked==true)
                    {  
                        cnt=1;
                    }   
               }  
           }     
           if(cnt==0)
           {               
               alert("Please Select Atleast One Option");
               return true;
           }
    }
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="Panel1" CssClass="Panel" GroupingText="Select Multiple CheckBox" runat="server">
            <table class="table">
                <tr>
                    <td class="td" align="center">
                        <asp:Label ID="LblOption" runat="server" Text="Select Multiple Options" CssClass="lblMsg"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="td">
                        <asp:CheckBoxList ID="ChkLstValue" runat="server" Font-Size="12px">
                            <asp:ListItem Value="http://www.msdn.com">.Net FrameWork</asp:ListItem>
                            <asp:ListItem Value="http://www.ASPNet.com">ASP.NET</asp:ListItem>
                            <asp:ListItem Value="http://www.Vbnet.com">VB.NET</asp:ListItem>
                            <asp:ListItem Value="http://www.csharpcorner.com">Csharp.NET</asp:ListItem>
                            <asp:ListItem Value="http://www.AjaxControlToolkit.com">AJAX</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td class="td" align="center">
                        <asp:Button ID="BtnSubmit" runat="server" Text="Submit" Width="121px" OnClick="BtnSubmit_Click"
                            OnClientClick="return SelectCheckBoxList();" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
