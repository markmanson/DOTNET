<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DAY14SendMail._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Compose Message</title>
    <link href="Stylesheet.css" rel="Stylesheet" type="text/css" />

    <script type="text/javascript" language="javascript">   
    function EnterValue(EnterTxtValue,alertText)
    {
        with(EnterTxtValue)
        {
            if(value=="" || value==null)
                { alert(alertText); return false;  }
            else{return true;}
        }
    }
    function Check()
    {
     with(Form1)
     {
        if(EnterValue(txtFrom,"Enter From Value")==false)
        {     txtFrom.focus();   return false;  }
        if(EnterValue(txtTo,"Enter To Value")==false)
        {txtTo.focus(); return false; }
     }
    }
    function CheckMailId(txtValue)
    {    
        with(txtValue)
        {    
            if(value!="")
            {
                var Value=/^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;
                var address=txtValue.value;
                if(Value.test(address)==false)
                {
                    alert("Invalid Email Address");
                    txtValue.focus();
                    txtValue.select();
                    return false;                
                }
                else{ return true; }
            }       
        }    
    }
    </script>
</head>
<body>
    <form id="Form1" runat="server" enctype="multipart/form-data">
    <asp:Panel ID="panel1" runat="Server" GroupingText="Send Mail" CssClass="Panel">
        <asp:Label ID="LblMsgSent" runat="server" Font-Bold="true" Visible="false" CssClass="lblControl"></asp:Label>
        <table class="table">
            <tr>
                <td align="left" class="td">
                    <asp:Label Text="From:" Font-Bold="true" CssClass="lblMsg" runat="server" ID="LblFrom"></asp:Label>
                </td>
                <td align="left">
                    <asp:TextBox ID="txtFrom" onblur="return CheckMailId(txtFrom);" runat="Server" Width="403px" />
                </td>
            </tr>
            <tr>
                <td align="left" class="td">
                    <asp:Label Text="To:" CssClass="lblMsg" Font-Bold="true" runat="server" ID="LblTo"></asp:Label>
                </td>
                <td align="left">
                    <asp:TextBox ID="txtTo" onblur="return CheckMailId(txtTo);" runat="Server" Width="403px" />
                </td>
            </tr>
            <tr>
                <td align="left" class="td">
                    <asp:Label Text="CC:" CssClass="lblMsg" Font-Bold="true" runat="server" ID="LblCC"></asp:Label>
                </td>
                <td align="left">
                    <asp:TextBox ID="txtCC" onblur="return CheckMailId(txtCC);" runat="Server" Width="403px" />
                </td>
            </tr>
            <tr>
                <td align="left" class="td">
                    <asp:Label Text="BCC:" CssClass="lblMsg" Font-Bold="true" runat="server" ID="LblBCC"></asp:Label>
                </td>
                <td align="left">
                    <asp:TextBox ID="txtBCC" onblur="return CheckMailId(txtBCC);" runat="Server" Width="403px" />
                </td>
            </tr>
            <tr>
                <td align="left" class="td">
                    <asp:Label Text="Subject:" CssClass="lblMsg" Font-Bold="true" runat="server" ID="LblSubject"></asp:Label>
                </td>
                <td align="left">
                    <asp:TextBox ID="txtSubject" runat="Server" Width="403px" />
                </td>
            </tr>
            <tr>
                <td align="left" class="td" colspan="2">
                    <asp:Label Text="Message Body:" CssClass="lblMsg" Font-Bold="true" runat="server"
                        ID="LblMessage"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td align="left" class="td">
                    <asp:TextBox ID="txtMessage" TextMode="MultiLine" Rows="6" runat="Server" Width="403px" />
                </td>
            </tr>
            <tr>
                <td class="td" align="left">
                    <asp:Label Text="Attach File:" CssClass="lblMsg" Font-Bold="true" runat="server"
                        ID="LblFileAttachment" Width="62px"></asp:Label>
                </td>
                <td>
                    <asp:FileUpload ID="FileUpload" runat="server" />
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <asp:Button ID="btnClear" runat="server" Text="Clear" Height="21px" Width="71px"
                        OnClick="btnClear_Click" />
                    <asp:Button ID="btnSend" runat="Server" OnClick="btnSend_Click" Text="Send>>" OnClientClick="return Check();"
                        Height="21px" />
                </td>
            </tr>
        </table>
    </asp:Panel>
    </form>
</body>
</html>
